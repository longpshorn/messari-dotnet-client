using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetMetrics
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("market_data")]
        public AssetMetricsMarketData MarketData { get; set; }
        [JsonProperty("supply")]
        public AssetMetricsSupply Supply { get; set; }
        [JsonProperty("blockchain_stats_24_hours")]
        public AssetMetricsBlockchainStats BlockchainStats24Hours { get; set; }
        [JsonProperty("all_time_high")]
        public AssetMetricsAllTimeHigh AllTimeHigh { get; set; }
        [JsonProperty("developer_activity")]
        public AssetMetricsDeveloperActivity DeveloperActivity { get; set; }
        [JsonProperty("roi_data")]
        public AssetMetricsRoiData RoiData { get; set; }
        [JsonProperty("misc_data")]
        public AssetMetricsMiscData MiscData { get; set; }
    }
}
