using Newtonsoft.Json;

namespace Agridator.Web.Data.Entities
{
    public class UsageType
    {
        [JsonProperty("ID")]
        public Guid Id { get; set; }

        [JsonProperty("LNF_Code")]
        public int Code { get; set; }

        public LocalizedStringSet Nutzung { get; set; } = new LocalizedStringSet();

        [JsonProperty("Gueltig_Von")]
        public int? ValidFromYear { get; set; }

        [JsonProperty("Gueltig_Bis")]
        public int? ValidToYear { get; set; }

        [JsonProperty("ueberlagernd")]
        public int Overlaying { get; set; }

        [JsonProperty("BFF_QI")]
        public int BffQi { get; set; }

        [JsonProperty("Spezialkultur")]
        public int SpezialCulture { get; set; }

    }
}
