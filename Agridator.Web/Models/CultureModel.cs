using Agridator.Web.Data.Entities;
using Newtonsoft.Json;

namespace Agridator.Web.Models
{
  public class CultureModel
  {
    public int Id { get; set; }

    public int CatId { get; set; }

    public int Cultureode { get; set; }

    public string Description { get; set; } = string.Empty;
  }
}
