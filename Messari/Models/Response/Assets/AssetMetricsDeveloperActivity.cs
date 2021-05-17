using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetMetricsDeveloperActivity
    {
        [JsonProperty("stars")]
        public int Stars { get; set; }
        [JsonProperty("watchers")] 
        public int Watchers { get; set; }
        [JsonProperty("commits_last_3_months")] 
        public int CommitsLast3Months { get; set; }
        [JsonProperty("commits_last_1_year")] 
        public int CommitsLast1Year { get; set; }
        [JsonProperty("lines_added_last_3_months")] 
        public int LinesAddedLast3Months { get; set; }
        [JsonProperty("lines_added_last_1_year")] 
        public int LinesAddedLast1Year { get; set; }
        [JsonProperty("lines_deleted_last_3_months")] 
        public int LinesDeletedLast3Months { get; set; }
        [JsonProperty("lines_deleted_last_1_year")] 
        public int LinesDeletedLast1Year { get; set; }
    }
}