using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetMetricsMiscData
    {
        [JsonProperty("asset_age_days")]
        public int AssetAgeDays { get; set; }
        [JsonProperty("vladimir_club_cost")]
        public double VladimirClubCost { get; set; }
        [JsonProperty("categories")]
        public List<string> Categories { get; set; } = new List<string>();
        [JsonProperty("sector")]
        public List<string> Sector { get; set; } = new List<string>();
    }
}