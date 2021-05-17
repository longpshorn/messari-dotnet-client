using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class NativeTreasuryAccount
    {
        [JsonProperty("account_type")]
        public string AccountType { get; set; }
        [JsonProperty("addresses")]
        public List<OfficialLink> Addresses { get; set; } = new List<OfficialLink>();
    }
}