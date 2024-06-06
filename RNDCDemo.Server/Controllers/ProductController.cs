using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace RNDCDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    [EnableCors("AllowAll")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProduct")]
        public JsonNode? Get()
        {
            string path = Directory.GetCurrentDirectory();
            using StreamReader reader = new(path + "/sampledata.json");
            JsonNode? summary = JsonNode.Parse(reader.ReadToEnd());
            return summary;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            if (id != 385)
            {
                return NotFound();
            }

            return Ok(Get());
        }
    }
}
