using System;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileLaunchInitialDistribution
    {
        [JsonProperty("initial_supply")]
        public double InitialSupply { get; set; }
        [JsonProperty("token_distribution_date")]
        public DateTime TokenDistributionDate { get; set; }
        [JsonProperty("genesis_block_date")]
        public DateTime GenesisBlockDate { get; set; }
        [JsonProperty("initial_supply_repartition")]
        public InitialSupplyRepartition InitialSupplyRepartition { get; set; }
    }
}