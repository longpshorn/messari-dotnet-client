using System;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetMetricsAllTimeHigh
    {
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("at")] 
        public DateTime At { get; set; }
        [JsonProperty("days_since")] 
        public int DaysSince { get; set; }
        [JsonProperty("percent_down")] 
        public double PercentDown { get; set; }
    }
}