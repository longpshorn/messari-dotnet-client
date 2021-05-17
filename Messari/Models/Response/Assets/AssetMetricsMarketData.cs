using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetMetricsMarketData
    {
        [JsonProperty("price_usd")]
        public double PriceUsd { get; set; }
        [JsonProperty("price_btc")]
        public double PriceBtc { get; set; }
        [JsonProperty("volume_last_24_hours")]
        public double VolumeLast24Hours { get; set; }
        [JsonProperty("real_volume_last_24_hours")]
        public double RealVolumeLast24Hours { get; set; }
        [JsonProperty("volume_last_24_hours_overstatement_multiple")]
        public double VolumeLast24HoursOverstatementMultiple { get; set; }
        [JsonProperty("percent_change_usd_last_24_hours")]
        public double PercentChangeUsdLast24Hours { get; set; }
        [JsonProperty("percent_change_btc_last_24_hours")]
        public double PercentChangeBtcLast24Hours { get; set; }
        [JsonProperty("ohlcv_last_1_hour")]
        public Ohlcv OhlcvLast1Hour { get; set; }
        [JsonProperty("ohlcv_last_24_hour")] 
        public Ohlcv OhlcvLast24Hour { get; set; }
    }
}
