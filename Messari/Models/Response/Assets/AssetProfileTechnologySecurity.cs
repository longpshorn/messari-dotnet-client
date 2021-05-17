using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileTechnologySecurity
    {
        [JsonProperty("audits")]
        public List<SecurityAudit> Audits { get; set; } = new List<SecurityAudit>();
        [JsonProperty("known_exploits_and_vulnerabilities")]
        public List<SecurityAudit> KnownExploitsAndVulnerabilities { get; set; } = new List<SecurityAudit>();
    }
}