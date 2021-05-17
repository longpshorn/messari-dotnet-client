using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileGovernanceGrant
    {
        [JsonProperty("grant_program_details")]
        public string GrantProgramDetails { get; set; }
        [JsonProperty("funding_organizations")]
        public List<Organization> FundingOrganizations { get; set; } = new List<Organization>();
    }
}