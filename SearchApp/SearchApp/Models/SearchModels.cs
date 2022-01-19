
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace SearchApp.Models
{
    public class SearchResults
    {
        [JsonProperty("Took")]
        public long Took { get; set; }

        [JsonProperty("Total")]
        public long Total { get; set; }

        [JsonProperty("MaxScore")]
        public long MaxScore { get; set; }

        [JsonProperty("Hits")]
        public Hit[] Hits { get; set; }
    }

    public class Hit
    {
        [JsonProperty("Score")]
        public long Score { get; set; }

        [JsonProperty("Source")]
        public Source Source { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }
    }

    public class Source
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("ProgramType")]
        public ProgramType ProgramType { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Title_completion")]
        public string TitleCompletion { get; set; }

        [JsonProperty("Created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("Modified")]
        public DateTimeOffset Modified { get; set; }

        [JsonProperty("OriginalTitle")]
        public string OriginalTitle { get; set; }

        [JsonProperty("OriginalTitle_completion")]
        public string OriginalTitleCompletion { get; set; }

        [JsonProperty("OriginalReleaseDate")]
        public DateTimeOffset OriginalReleaseDate { get; set; }

        [JsonProperty("Year")]
        public long Year { get; set; }

        [JsonProperty("OriginalLanguage")]
        public OriginalLanguage OriginalLanguage { get; set; }

        [JsonProperty("Deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Releases")]
        public Release[] Releases { get; set; }

        [JsonProperty("VersionId")]
        public long VersionId { get; set; }

        [JsonProperty("VideoCount")]
        public long VideoCount { get; set; }

        [JsonProperty("ImageCount")]
        public long ImageCount { get; set; }

        [JsonProperty("IvaRating")]
        public long IvaRating { get; set; }

        [JsonProperty("IvaRatingSort")]
        public double IvaRatingSort { get; set; }

        [JsonProperty("TimeStamp")]
        public DateTimeOffset TimeStamp { get; set; }

        [JsonProperty("Packages")]
        public Package[] Packages { get; set; }

        [JsonProperty("Budget", NullValueHandling = NullValueHandling.Ignore)]
        public long? Budget { get; set; }

        [JsonProperty("Runtime", NullValueHandling = NullValueHandling.Ignore)]
        public long? Runtime { get; set; }

        [JsonProperty("Revenue", NullValueHandling = NullValueHandling.Ignore)]
        public long? Revenue { get; set; }

        [JsonProperty("OfficialSiteUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri OfficialSiteUrl { get; set; }
    }

    public class Release
    {
        [JsonProperty("Date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("CountryName")]
        public string CountryName { get; set; }

        [JsonProperty("CountryId")]
        public long CountryId { get; set; }

        [JsonProperty("Type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("Certification", NullValueHandling = NullValueHandling.Ignore)]
        public string Certification { get; set; }
    }

    public enum OriginalLanguage { English, Mandarin, Spanish };

    public enum Package { AllAccess, EntertainmentDiscovery };

    public enum ProgramType { Movie };

    public enum TypeEnum { Digital, Premiere, TheatricalLimitedRelease, TheatricalWideRelease, Tv };

    public enum Status { Released };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                OriginalLanguageConverter.Singleton,
                PackageConverter.Singleton,
                ProgramTypeConverter.Singleton,
                TypeEnumConverter.Singleton,
                StatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class OriginalLanguageConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OriginalLanguage) || t == typeof(OriginalLanguage?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "English":
                    return OriginalLanguage.English;
                case "Mandarin":
                    return OriginalLanguage.Mandarin;
                case "Spanish":
                    return OriginalLanguage.Spanish;
            }
            throw new Exception("Cannot unmarshal type OriginalLanguage");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (OriginalLanguage)untypedValue;
            switch (value)
            {
                case OriginalLanguage.English:
                    serializer.Serialize(writer, "English");
                    return;
                case OriginalLanguage.Mandarin:
                    serializer.Serialize(writer, "Mandarin");
                    return;
                case OriginalLanguage.Spanish:
                    serializer.Serialize(writer, "Spanish");
                    return;
            }
            throw new Exception("Cannot marshal type OriginalLanguage");
        }

        public static readonly OriginalLanguageConverter Singleton = new OriginalLanguageConverter();
    }

    internal class PackageConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Package) || t == typeof(Package?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AllAccess":
                    return Package.AllAccess;
                case "EntertainmentDiscovery":
                    return Package.EntertainmentDiscovery;
            }
            throw new Exception("Cannot unmarshal type Package");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Package)untypedValue;
            switch (value)
            {
                case Package.AllAccess:
                    serializer.Serialize(writer, "AllAccess");
                    return;
                case Package.EntertainmentDiscovery:
                    serializer.Serialize(writer, "EntertainmentDiscovery");
                    return;
            }
            throw new Exception("Cannot marshal type Package");
        }

        public static readonly PackageConverter Singleton = new PackageConverter();
    }

    internal class ProgramTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ProgramType) || t == typeof(ProgramType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Movie")
            {
                return ProgramType.Movie;
            }
            throw new Exception("Cannot unmarshal type ProgramType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ProgramType)untypedValue;
            if (value == ProgramType.Movie)
            {
                serializer.Serialize(writer, "Movie");
                return;
            }
            throw new Exception("Cannot marshal type ProgramType");
        }

        public static readonly ProgramTypeConverter Singleton = new ProgramTypeConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Digital":
                    return TypeEnum.Digital;
                case "Premiere":
                    return TypeEnum.Premiere;
                case "TV":
                    return TypeEnum.Tv;
                case "Theatrical_Limited_Release":
                    return TypeEnum.TheatricalLimitedRelease;
                case "Theatrical_Wide_Release":
                    return TypeEnum.TheatricalWideRelease;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Digital:
                    serializer.Serialize(writer, "Digital");
                    return;
                case TypeEnum.Premiere:
                    serializer.Serialize(writer, "Premiere");
                    return;
                case TypeEnum.Tv:
                    serializer.Serialize(writer, "TV");
                    return;
                case TypeEnum.TheatricalLimitedRelease:
                    serializer.Serialize(writer, "Theatrical_Limited_Release");
                    return;
                case TypeEnum.TheatricalWideRelease:
                    serializer.Serialize(writer, "Theatrical_Wide_Release");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Released")
            {
                return Status.Released;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            if (value == Status.Released)
            {
                serializer.Serialize(writer, "Released");
                return;
            }
            throw new Exception("Cannot marshal type Status");
        }
        public static readonly StatusConverter Singleton = new StatusConverter();
    }
}
