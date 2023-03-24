using Newtonsoft.Json;

namespace Agridator.Web.Data.Entities
{
    public class TypeOfWork
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }

        public LocalizedStringSet Title { get; set; } = new LocalizedStringSet();
    }
}
