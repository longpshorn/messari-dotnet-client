using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class ConsensusAndEmissionSupply
    {
        [JsonProperty("supply_curve_details")]
        public string SupplyCurveDetails { get; set; }
        [JsonProperty("general_emission_type")]
        public string GeneralEmissionType { get; set; }
        [JsonProperty("precise_emission_type")] 
        public string PreciseEmissionType { get; set; }
        [JsonProperty("is_capped_supply")] 
        public bool IsCappedSupply { get; set; }
        [JsonProperty("max_supply")] 
        public long MaxSupply { get; set; }
    }
}