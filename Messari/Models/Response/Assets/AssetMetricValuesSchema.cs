using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetMetricValuesSchema
    {
        [JsonProperty("block_uncle_rewards_usd")]
        public string BlockUncleRewardsUsd { get; set; }
        [JsonProperty("exchange_flow_out_bitmex_usd")]
        public string ExchangeFlowOutBitmexUsd { get; set; }
    }
}