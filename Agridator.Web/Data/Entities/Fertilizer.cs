using Newtonsoft.Json;

namespace Agridator.Web.Data.Entities
{
    public class Fertilizer
    {
        [JsonProperty("DWH_SK")]
        public int Id { get; set; }

        public LocalizedStringSet Description { get; set; } = new LocalizedStringSet();

        [JsonProperty("PST_STATUS")]
        public string Status { get; set; } = string.Empty;
    }
}
