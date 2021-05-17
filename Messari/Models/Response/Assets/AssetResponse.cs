using System;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetResponse
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("name")] 
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("profile")]
        public AssetProfile Profile { get; set; }
        [JsonProperty("metrics")]
        public AssetMetrics Metrics { get; set; }
    }
}
