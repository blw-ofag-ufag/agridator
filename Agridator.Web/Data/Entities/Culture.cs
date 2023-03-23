using Newtonsoft.Json;

namespace Agridator.Web.Data.Entities
{
    public class Culture
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }

        [JsonProperty(nameof(CatId))]
        public int CatId { get; set; }
        [JsonIgnore]
        public CultureCategories Category { get; set; } = null!;

        [JsonProperty(nameof(Cultureode))]
        public int Cultureode { get; set; }

        [JsonProperty(nameof(Description_de))]
        public string Description_de { get; set; } = string.Empty;

        [JsonProperty(nameof(Description_fr))]
        public string Description_fr { get; set; } = string.Empty;

        [JsonProperty(nameof(Description_it))]
        public string Description_it { get; set; } = string.Empty;

    }
}
