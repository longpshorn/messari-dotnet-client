using System;
using System.Collections.Generic;
using Messari.Helper;
using Messari.Models.Request;
using Newtonsoft.Json;

namespace Messari.Models.Response
{
    public class TimeSeriesSchema
    {
        [JsonProperty("metric_id")]
        public string MetricId { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("values_schema")]
        public object ValuesSchema { get; set; }
        [JsonProperty("minimum_interval")]
        [JsonConverter(typeof(IntervalConverter))]
        public Interval MinimumInterval { get; set; }
        [JsonProperty("first_available")]
        public DateTime FirstAvailable { get; set; }
        [JsonProperty("source_attribution")] 
        public List<SoureAttribution> SourceAttribution { get; set; }
    }
}