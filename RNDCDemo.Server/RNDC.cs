﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'System.Text.Json' then do:
//
//    using QuickType;
//
//    var product = Product.FromJson(jsonString);
#nullable enable
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603

namespace RNDC
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;

    public partial class Product
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("ExDoNotUse")]
        public string ExDoNotUse { get; set; }

        [JsonPropertyName("ExBarrel")]
        public string ExBarrel { get; set; }

        [JsonPropertyName("ExUPC")]
        public string ExUpc { get; set; }

        [JsonPropertyName("ExSCC")]
        public string ExScc { get; set; }

        [JsonPropertyName("ExCorpMDMID")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ExCorpMdmid { get; set; }

        [JsonPropertyName("ExRefOnly")]
        public string ExRefOnly { get; set; }

        [JsonPropertyName("ExProductSKU_ExUnitOfMeasure_1_rowidObject")]
        public string ExProductSkuExUnitOfMeasure1_RowidObject { get; set; }

        [JsonPropertyName("ExProductSKU_rowidObject")]
        public string ExProductSkuRowidObject { get; set; }

        [JsonPropertyName("ExRefProduct")]
        public ExRefProduct ExRefProduct { get; set; }

        [JsonPropertyName("ExProductAltId")]
        public ExProductAltId ExProductAltId { get; set; }
    }

    public partial class ExProductAltId
    {
        [JsonPropertyName("link")]
        public object[] Link { get; set; }

        [JsonPropertyName("firstRecord")]
        public long FirstRecord { get; set; }

        [JsonPropertyName("pageSize")]
        public long PageSize { get; set; }

        [JsonPropertyName("searchToken")]
        public string SearchToken { get; set; }

        [JsonPropertyName("item")]
        public ExProductAltIdItem[] Item { get; set; }
    }

    public partial class ExProductAltIdItem
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("ExAltID")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ExAltId { get; set; }

        [JsonPropertyName("ExAltIDType")]
        public ExAltIdType ExAltIdType { get; set; }
    }

    public partial class ExAltIdType
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("ExAltIDTypeDesc")]
        public string ExAltIdTypeDesc { get; set; }

        [JsonPropertyName("ExAltIDType")]
        public string ExAltIdTypeExAltIdType { get; set; }
    }

    public partial class ExRefProduct
    {
        [JsonPropertyName("ExVntgCrp")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ExVntgCrp { get; set; }

        [JsonPropertyName("ExProof")]
        public string ExProof { get; set; }

        [JsonPropertyName("ExItemLife")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ExItemLife { get; set; }

        [JsonPropertyName("ExABV")]
        public string ExAbv { get; set; }

        [JsonPropertyName("ExDscrptnFull")]
        public string ExDscrptnFull { get; set; }

        [JsonPropertyName("ExCrpCrtfd")]
        public string ExCrpCrtfd { get; set; }

        [JsonPropertyName("ExVntgSnstvCrp")]
        public string ExVntgSnstvCrp { get; set; }

        [JsonPropertyName("ExDscrptn")]
        public string ExDscrptn { get; set; }

        [JsonPropertyName("ExCrpClass")]
        public ExCrpClass ExCrpClass { get; set; }

        [JsonPropertyName("ExTempProtectionFlg")]
        public string ExTempProtectionFlg { get; set; }

        [JsonPropertyName("ExUnitOfMeasure")]
        public ExUnitOfMeasure ExUnitOfMeasure { get; set; }

        [JsonPropertyName("ExProductContainer")]
        public ExProductContainer ExProductContainer { get; set; }
    }

    public partial class ExCrpClass
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("ExCorporateClassDesc")]
        public string ExCorporateClassDesc { get; set; }

        [JsonPropertyName("ExCrpClassID")]
        public string ExCrpClassId { get; set; }
    }

    public partial class ExProductContainer
    {
        [JsonPropertyName("link")]
        public object[] Link { get; set; }

        [JsonPropertyName("firstRecord")]
        public long FirstRecord { get; set; }

        [JsonPropertyName("pageSize")]
        public long PageSize { get; set; }

        [JsonPropertyName("searchToken")]
        public string SearchToken { get; set; }

        [JsonPropertyName("item")]
        public ExProductContainerItem[] Item { get; set; }
    }

    public partial class ExProductContainerItem
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("ExPalletType")]
        public string ExPalletType { get; set; }

        [JsonPropertyName("ExCntnrType")]
        public ExCntnrType ExCntnrType { get; set; }

        [JsonPropertyName("ExClosureTyp")]
        public ExClosureTyp ExClosureTyp { get; set; }

        [JsonPropertyName("ExSzDscrptr")]
        public ExSzDscrptr ExSzDscrptr { get; set; }

        [JsonPropertyName("ExProductLabel")]
        public ExProductLabel ExProductLabel { get; set; }
    }

    public partial class ExClosureTyp
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("ExClsrTypeDesc")]
        public string ExClsrTypeDesc { get; set; }

        [JsonPropertyName("ExClsrTypId")]
        public string ExClsrTypId { get; set; }
    }

    public partial class ExCntnrType
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("ExCntnrTypeDesc")]
        public string ExCntnrTypeDesc { get; set; }

        [JsonPropertyName("ExCntnrTypeID")]
        public string ExCntnrTypeId { get; set; }
    }

    public partial class ExProductLabel
    {
        [JsonPropertyName("link")]
        public object[] Link { get; set; }

        [JsonPropertyName("firstRecord")]
        public long FirstRecord { get; set; }

        [JsonPropertyName("pageSize")]
        public long PageSize { get; set; }

        [JsonPropertyName("searchToken")]
        public string SearchToken { get; set; }

        [JsonPropertyName("item")]
        public ExProductLabelItem[] Item { get; set; }
    }

    public partial class ExProductLabelItem
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("ExColor")]
        public ExColor ExColor { get; set; }

        [JsonPropertyName("ExLabelNm")]
        public string ExLabelNm { get; set; }

        [JsonPropertyName("ExRegion")]
        public string ExRegion { get; set; }

        [JsonPropertyName("ExState")]
        public ExState ExState { get; set; }

        [JsonPropertyName("ExCountry")]
        public ExCountry ExCountry { get; set; }

        [JsonPropertyName("ExProductBrand")]
        public ExProductBrand ExProductBrand { get; set; }
    }

    public partial class ExColor
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("ExColorDesc")]
        public string ExColorDesc { get; set; }

        [JsonPropertyName("ExColorID")]
        public string ExColorId { get; set; }
    }

    public partial class ExCountry
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("countryDesc")]
        public string CountryDesc { get; set; }
    }

    public partial class ExProductBrand
    {
        [JsonPropertyName("link")]
        public object[] Link { get; set; }

        [JsonPropertyName("firstRecord")]
        public long FirstRecord { get; set; }

        [JsonPropertyName("pageSize")]
        public long PageSize { get; set; }

        [JsonPropertyName("searchToken")]
        public string SearchToken { get; set; }

        [JsonPropertyName("item")]
        public ExProductBrandItem[] Item { get; set; }
    }

    public partial class ExProductBrandItem
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("ExBrandNm")]
        public string ExBrandNm { get; set; }
    }

    public partial class ExState
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("stateCode")]
        public string StateCode { get; set; }

        [JsonPropertyName("stateDesc")]
        public string StateDesc { get; set; }
    }

    public partial class ExSzDscrptr
    {
        [JsonPropertyName("rowidObject")]
        public string RowidObject { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("ExSizeDesc")]
        public string ExSizeDesc { get; set; }

        [JsonPropertyName("ExSzDscrptrID")]
        public string ExSzDscrptrId { get; set; }
    }

    public partial class ExUnitOfMeasure
    {
        [JsonPropertyName("ExCasesPerPallet")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ExCasesPerPallet { get; set; }

        [JsonPropertyName("ExLiters")]
        public string ExLiters { get; set; }

        [JsonPropertyName("ExCaseWidth")]
        public string ExCaseWidth { get; set; }

        [JsonPropertyName("ExCaseHeight")]
        public string ExCaseHeight { get; set; }

        [JsonPropertyName("ExGallonage")]
        public string ExGallonage { get; set; }

        [JsonPropertyName("ExCaseWeight")]
        public string ExCaseWeight { get; set; }

        [JsonPropertyName("ExCaseLength")]
        public string ExCaseLength { get; set; }

        [JsonPropertyName("ExCasesPerLayer")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ExCasesPerLayer { get; set; }

        [JsonPropertyName("ExTrueBtlsPerCase")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ExTrueBtlsPerCase { get; set; }

        [JsonPropertyName("ExCaseEqvlnt")]
        public string ExCaseEqvlnt { get; set; }

        [JsonPropertyName("ExBttlCase")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ExBttlCase { get; set; }

        [JsonPropertyName("ExMultiPack")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ExMultiPack { get; set; }
    }

    public partial class Product
    {
        public static Product FromJson(string json) => JsonSerializer.Deserialize<Product>(json);
    }

    public static class Serialize
    {
        public static string ToJson(this Product self) => JsonSerializer.Serialize(self);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }

    internal class ParseStringConverter : JsonConverter<long>
    {
        public override bool CanConvert(Type t) => t == typeof(long);

        public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.ToString(), options);
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    public class DateOnlyConverter : JsonConverter<DateOnly>
    {
        private readonly string serializationFormat;
        public DateOnlyConverter() : this(null) { }

        public DateOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "yyyy-MM-dd";
        }

        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return DateOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
                => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    public class TimeOnlyConverter : JsonConverter<TimeOnly>
    {
        private readonly string serializationFormat;

        public TimeOnlyConverter() : this(null) { }

        public TimeOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "HH:mm:ss.fff";
        }

        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return TimeOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
                => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    internal class IsoDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        public override bool CanConvert(Type t) => t == typeof(DateTimeOffset);

        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;
        private string? _dateTimeFormat;
        private CultureInfo? _culture;

        public DateTimeStyles DateTimeStyles
        {
            get => _dateTimeStyles;
            set => _dateTimeStyles = value;
        }

        public string? DateTimeFormat
        {
            get => _dateTimeFormat ?? string.Empty;
            set => _dateTimeFormat = (string.IsNullOrEmpty(value)) ? null : value;
        }

        public CultureInfo Culture
        {
            get => _culture ?? CultureInfo.CurrentCulture;
            set => _culture = value;
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            string text;


            if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                    || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
            {
                value = value.ToUniversalTime();
            }

            text = value.ToString(_dateTimeFormat ?? DefaultDateTimeFormat, Culture);

            writer.WriteStringValue(text);
        }

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? dateText = reader.GetString();

            if (string.IsNullOrEmpty(dateText) == false)
            {
                if (!string.IsNullOrEmpty(_dateTimeFormat))
                {
                    return DateTimeOffset.ParseExact(dateText, _dateTimeFormat, Culture, _dateTimeStyles);
                }
                else
                {
                    return DateTimeOffset.Parse(dateText, Culture, _dateTimeStyles);
                }
            }
            else
            {
                return default(DateTimeOffset);
            }
        }


        public static readonly IsoDateTimeOffsetConverter Singleton = new IsoDateTimeOffsetConverter();
    }
}
