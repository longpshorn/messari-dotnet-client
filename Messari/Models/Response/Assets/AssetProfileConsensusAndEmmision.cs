using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileConsensusAndEmmision
    {
        [JsonProperty("supply")]
        public ConsensusAndEmissionSupply Supply { get; set; }
        [JsonProperty("consensus")]
        public ConsensusAndEmissionsConsensus Consensus { get; set; }
    }
}