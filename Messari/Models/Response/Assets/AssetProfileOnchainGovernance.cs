using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileOnchainGovernance
    {
        [JsonProperty("onchain_governance_type")]
        public string OnchainGovernanceType { get; set; }
        [JsonProperty("onchain_governance_details")]
        public string OnchainGovernanceDetails { get; set; }
        [JsonProperty("is_treasury_decentralized")]
        public bool IsTreasuryDecentralized { get; set; }
    }
}