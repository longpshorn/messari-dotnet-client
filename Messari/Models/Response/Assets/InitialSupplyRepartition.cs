using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class InitialSupplyRepartition
    {
        [JsonProperty("allocated_to_investors_percentage")]
        public double AllocatedTOInvestorsPercentage { get; set; }
        [JsonProperty("allocated_to_organization_or_founders_percentage")]
        public double AllocatedToOrganizationOrFoundersPercentage { get; set; }
        [JsonProperty("allocated_to_premined_rewards_or_airdrops_percentage")]
        public double AllocatedToPreminedRewardsOrAirdropsPercentage { get; set; }
    }
}