using System;
using Newtonsoft.Json;

namespace Messari.Models.Response.Markets
{
    public class TimeSeriesMarketParameters : TimeSeriesParametersBase
    {

        [JsonProperty("market_key")]
        public string MarketKey { get; set; }
        [JsonProperty("market_id")]
        public Guid MarketId { get; set; }
    }
}