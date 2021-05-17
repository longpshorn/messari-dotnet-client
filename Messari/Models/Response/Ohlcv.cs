using Newtonsoft.Json;

namespace Messari.Models.Response
{
    public class Ohlcv
    {
        [JsonProperty("open")]
        public double Open { get; set; }
        [JsonProperty("high")] 
        public double High { get; set; }
        [JsonProperty("low")] 
        public double Low { get; set; }
        [JsonProperty("close")] 
        public double Close { get; set; }
        [JsonProperty("volume")] 
        public double Volume { get; set; }
    }
}
