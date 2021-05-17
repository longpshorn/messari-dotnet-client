using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class TimeSeriesAssetResponse
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("symbol")] 
        public string Symbol { get; set; }
        [JsonProperty("name")] 
        public string Name { get; set; }
        [JsonProperty("slug")] 
        public string Slug { get; set; }
        [JsonProperty("parameters")]
        public TimeSeriesAssetParameters Parameters { get; set; }
        [JsonProperty("schema")]
        public TimeSeriesSchema Schema { get; set; }
        [JsonProperty("values")]
        public List<List<dynamic>> Values { get; set; } = new List<List<dynamic>>();
    }
}