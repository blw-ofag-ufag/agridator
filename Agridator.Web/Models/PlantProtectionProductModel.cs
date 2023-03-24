using Newtonsoft.Json;

namespace Agridator.Web.Models
{
  public class PlantProtectionProductModel
  {
    public int Id { get; set; }

    public string ProductName { get; set; } = string.Empty;

    public int WNr { get; set; }

    public string CompanyName { get; set; } = string.Empty;

    public string ActiveSubstances { get; set; } = string.Empty;
  }
}
