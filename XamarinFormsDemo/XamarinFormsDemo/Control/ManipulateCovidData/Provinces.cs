using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace XamarinFormsDemo.Control.ManipulateCovidData
{
    class Provinces
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        //[JsonPropertyName("areas")]
        //public IList<Cities> Cities { get; set; }
        [JsonPropertyName("totalConfirmed")]
        public int? TotalConfirmed { get; set; }
        [JsonPropertyName("totalDeaths")]
        public int? TotalDeaths { get; set; }
        [JsonPropertyName("totalRecovered")]
        public int? TotalRecovered { get; set; }
        [JsonPropertyName("totalRecoveredDelta")]
        public int? TotalRecoveredDelta { get; set; }
        [JsonPropertyName("totalDeathsDelta")]
        public int? TotalDeathsDelta { get; set; }
        [JsonPropertyName("totalConfirmedDelta")]
        public int? TotalConfirmedDelta { get; set; }
        [JsonPropertyName("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }
        public float? Lat { get; set; }
        [JsonPropertyName("long")]
        public float? Long { get; set; }
        [JsonPropertyName("parentId")]
        public string ParentId { get; set; }
    }
}
