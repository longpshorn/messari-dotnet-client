using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Markets
{
    public class TimeSeriesMarketResponse
    {
        [JsonProperty("market_id")]
        public Guid MarketId { get; set; }
        [JsonProperty("market_name")] 
        public string MarketName { get; set; }
        [JsonProperty("market_slug")] 
        public string MarketSlug { get; set; }
        [JsonProperty("parameters")]
        public TimeSeriesMarketParameters Parameters { get; set; }
        [JsonProperty("schema")]
        public TimeSeriesSchema Schema { get; set; }
        [JsonProperty("values")]
        public List<List<dynamic>> Values { get; set; } = new List<List<dynamic>>();
    }
}