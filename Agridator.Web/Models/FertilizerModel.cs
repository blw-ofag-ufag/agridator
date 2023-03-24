using Agridator.Web.Data.Entities;
using Newtonsoft.Json;

namespace Agridator.Web.Models
{
  public class FertilizerModel
  {
    public int Id { get; set; }

    public string Description { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;
  }
}
