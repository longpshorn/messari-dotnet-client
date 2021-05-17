using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileGovernance
    {
        [JsonProperty("governance_details")]
        public string GovernanceDetails { get; set; }
        [JsonProperty("onchain_governance")]
        public AssetProfileOnchainGovernance OnchainGovernance { get; set; }
        [JsonProperty("grants")]
        public List<AssetProfileGovernanceGrant> Grants { get; set; } = new List<AssetProfileGovernanceGrant>();
    }
}