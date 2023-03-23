using Newtonsoft.Json;

namespace Agridator.Web.Data.Entities
{
    public class UsageTypes
    {
        [JsonProperty("ID")]
        public Guid Id { get; set; }

        [JsonProperty("LNF_Code")]
        public int Code { get; set; }

        [JsonProperty("Nutzung_DE")]
        public string Nutzung_de { get; set; } = string.Empty;

        [JsonProperty("Nutzung_FR")]
        public string Nutzung_fr { get; set; } = string.Empty;

        [JsonProperty("Nutzung_IT")]
        public string Nutzung_it { get; set; } = string.Empty;

        [JsonProperty("Gueltig_Von")]
        public int ValidFromYear { get; set; }

        [JsonProperty("Gueltig_Bis")]
        public int ValidToYear { get; set; }

        [JsonProperty("ueberlagernd")]
        public int Overlaying { get; set; }

        [JsonProperty("BFF_QI")]
        public bool BffQi { get; set; }

        [JsonProperty("Spezialkultur")]
        public bool SpezialCulture { get; set; }

    }
}
