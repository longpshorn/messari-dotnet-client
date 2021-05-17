using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetMetricsList
    {
        [JsonProperty("metrics")]
        public List<AssetMetric> Metrics { get; set; } = new List<AssetMetric>();
    }
}