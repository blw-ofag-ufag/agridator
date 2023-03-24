namespace Agridator.Web.Models
{
  public class UsageTypeModel
  {
    public Guid Id { get; set; }

    public int Code { get; set; }

    public string Nutzung { get; set; } = string.Empty;

    public int? ValidFromYear { get; set; }

    public int? ValidToYear { get; set; }

    public int Overlaying { get; set; }

    public bool BffQi { get; set; }

    public bool SpezialCulture { get; set; }
  }
}
