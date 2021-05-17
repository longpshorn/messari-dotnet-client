using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileGeneral
    {
        [JsonProperty("overview")] 
        public AssetProfileGeneralOverview Overview { get; set; }
        [JsonProperty("background")] 
        public AssetProfileGeneralBackground Background { get; set; }
        [JsonProperty("regulation")]
        public AssetProfileGeneralRegulation Regulation { get; set; }
        [JsonProperty("roadmap")]
        public List<AssetProfileGeneralRoadmap> Roadmap { get; set; } = new List<AssetProfileGeneralRoadmap>();
    }
}