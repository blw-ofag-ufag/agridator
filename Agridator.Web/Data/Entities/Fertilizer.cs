using Newtonsoft.Json;

namespace Agridator.Web.Data.Entities
{
    internal class Fertilizer
    {
        [JsonProperty("DWH_SK")]
        public int Id { get; set; }

        [JsonProperty("PST_DESCRIPTION_DE")]
        public string Description_de { get; set; } = string.Empty;

        [JsonProperty("PST_DESCRIPTION_FR")]
        public string Description_fr { get; set; } = string.Empty;

        [JsonProperty("PST_DESCRIPTION_IT")]
        public string Description_it { get; set; } = string.Empty;

        [JsonProperty("PST_STATUS")]
        public string Status { get; set; } = string.Empty;
    }
}
