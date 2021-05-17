using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileEconomics
    {
        [JsonProperty("token")]
        public AssetProfileToken Token { get; set; }
        [JsonProperty("launch")]
        public AssetProfileLaunch Launch { get; set; }
        [JsonProperty("consensus_and_emission")]
        public AssetProfileConsensusAndEmmision ConsensusAndEmission { get; set; }
        [JsonProperty("native_treasury")]
        public AssetProfileNativeTreasury NativeTreasury { get; set; }
    }
}