using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileToken
    {
        [JsonProperty("token_name")]
        public string TokenName { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("token_usage")]
        public string TokenUsage { get; set; }
        [JsonProperty("token_usage_details_and_wallets")]
        public string TokenUsageDetailsAndWallets { get; set; }
        [JsonProperty("block_explorers")]
        public List<OfficialLink> BlockExplorers { get; set; } = new List<OfficialLink>();
        [JsonProperty("multitoken")]
        public List<Asset> Multitoken { get; set; }
    }
}