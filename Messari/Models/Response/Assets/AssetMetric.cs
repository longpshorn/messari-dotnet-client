using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetMetric
    {
        [JsonProperty("metric_id")]
        public string MetricId { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("minimum_interval")]
        public string MinimumInterval { get; set; }
        [JsonProperty("values_schema")]
        public AssetMetricValuesSchema ValuesSchema { get; set; }
        [JsonProperty("role_restriction")]
        public List<string> RoleRestriction { get; set; } = new List<string>();
        public List<SoureAttribution> SourceAttribution { get; set; } = new List<SoureAttribution>();
    }
}