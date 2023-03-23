using Newtonsoft.Json;

namespace Agridator.Web.Data.Entities
{
    public class TypeOfWork
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }

        [JsonProperty(nameof(Title_de))]
        public string Title_de { get; set; } = string.Empty;

        [JsonProperty(nameof(Title_fr))]
        public string Title_fr { get; set; } = string.Empty;

        [JsonProperty(nameof(Title_it))]
        public string Title_it { get; set; } = string.Empty;
    }
}
