using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileLaunchFundraising
    {
        [JsonProperty("sales_rounds")]
        public List<AssetProfileLaunchFundraisingSalesRound> SalesRounds { get; set; } = new List<AssetProfileLaunchFundraisingSalesRound>();
        [JsonProperty("sales_documents")]
        public List<OfficialLink> SalesDocuments { get; set; } = new List<OfficialLink>();
        [JsonProperty("sales_treasury_accounts")]
        public List<AssetProfileLaunchFundraisingSalesTreasuryAccount> SalesTreasuryAccounts { get; set; } = new List<AssetProfileLaunchFundraisingSalesTreasuryAccount>();
        [JsonProperty("treasury_policies")]
        public List<OfficialLink> TreasuryPolicies { get; set; } = new List<OfficialLink>();
        [JsonProperty("projected_use_of_sales_proceeds")]
        public List<SalesProceed> ProjectedUseOfSalesProceeds { get; set; }
    }
}