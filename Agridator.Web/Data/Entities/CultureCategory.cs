using Newtonsoft.Json;

namespace Agridator.Web.Data.Entities
{
    public class CultureCategory
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }

        public LocalizedStringSet Description { get; set; } = new LocalizedStringSet();

        public virtual List<Culture> Cultures { get; set; } = new List<Culture>();
    }
}
