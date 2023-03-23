using Newtonsoft.Json;

namespace Agridator.Web.Data.Entities
{
    public class CultureCategories
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }

        [JsonProperty(nameof(Description))]
        public string Description { get; set; } = string.Empty;

        public virtual List<Culture> Cultures { get; set; } = new List<Culture>();
    }
}
