using Newtonsoft.Json;

namespace Agridator.Web.Data.Entities
{
    public class PlantProtectionProducts
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }

        [JsonProperty(nameof(ProductName))]
        public string ProductName { get; set; } = string.Empty;

        [JsonProperty(nameof(WNr))]
        public int WNr { get; set; }

        [JsonProperty(nameof(CompanyName))]
        public string CompanyName { get; set; } = string.Empty;

        [JsonProperty(nameof(ActiveSubstances))]
        public string ActiveSubstances { get; set; } = string.Empty;
    }
}
