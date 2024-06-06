using idunno.Authentication.Basic;
using idunno.Authentication.Certificate;
using System.Security.Claims;
using Web.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll", policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()/*.AllowCredentials()*/);
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* Basic Auth Feature: Username and Password must match to authenticate */
builder.Services.AddAuthentication(BasicAuthenticationDefaults.AuthenticationScheme).AddBasic(options =>
{
    options.Realm = "rndcdemo";
    options.Events = new BasicAuthenticationEvents
    {
        OnValidateCredentials = context =>
        {
            if (context.Username == context.Password)
            {
                var claims = new[]
                {
                                new Claim(
                                    ClaimTypes.NameIdentifier,
                                    context.Username,
                                    ClaimValueTypes.String,
                                    context.Options.ClaimsIssuer),
                                new Claim(
                                    ClaimTypes.Name,
                                    context.Username,
                                    ClaimValueTypes.String,
                                    context.Options.ClaimsIssuer)
                            };

                context.Principal = new ClaimsPrincipal(
                    new ClaimsIdentity(claims, context.Scheme.Name));
                context.Success();
            }

            return Task.CompletedTask;
        }
    };
})
.AddCertificate();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.UseCors();
app.UseOptions();

app.MapControllers();

app.Run();
