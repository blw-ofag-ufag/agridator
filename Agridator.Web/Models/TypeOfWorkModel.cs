using Newtonsoft.Json;

namespace Agridator.Web.Models
{
  public class TypeOfWorkModel
  {
    public int Id { get; set; }

    public string Title_de { get; set; } = string.Empty;

    public string Title_fr { get; set; } = string.Empty;

    public string Title_it { get; set; } = string.Empty;
  }
}
