using System.Text.Json.Serialization;

namespace BuildingSearch.Models
{
    public class Building
    {
        public int Id { get; set; }
        [JsonPropertyName("BATCH NO.")]
        public long BATCH_NO { get; set; }
        [JsonPropertyName("CAD ZONE")]
        public string CAD_ZONE { get; set; }
        [JsonPropertyName("PLOT NO.")]
        public long PLOT_NO { get; set; }
        [JsonPropertyName("FILE NUMBER")]
        public string FILE_NUMBER { get; set; }
        [JsonPropertyName("DEVELOPER’S NAME")]
        public string DEVELOPER_S_NAME { get; set; }
        public string DATE { get; set; }
        [JsonPropertyName("DATE RETURNED")]
        public string DATE_RETURNED { get; set; }
        [JsonPropertyName("ORIGINAL FILE LOCATION")]
        public string ORIGINAL_FILE_LOCATION { get; set; }
    }
}
