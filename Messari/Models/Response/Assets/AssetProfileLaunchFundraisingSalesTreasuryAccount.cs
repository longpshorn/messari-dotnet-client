using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileLaunchFundraisingSalesTreasuryAccount
    {
        [JsonProperty("account_type")]
        public string AccountType { get; set; }
        [JsonProperty("security")]
        public string Security { get; set; }
        [JsonProperty("asset_held")]
        public Asset AssetHeld { get; set; }
        [JsonProperty("addresses")]
        public List<OfficialLink> Addresses { get; set; } = new List<OfficialLink>();
    }
}