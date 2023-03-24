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
        public CultureCategory Category { get; set; } = null!;

        [JsonProperty(nameof(Cultureode))]
        public int Cultureode { get; set; }

        public LocalizedStringSet Description { get; set; } = new LocalizedStringSet();
    }
}
