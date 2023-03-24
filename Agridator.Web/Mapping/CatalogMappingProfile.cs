using Agridator.Web.Data.Entities;
using Agridator.Web.Models;
using AutoMapper;

namespace Agridator.Web.Mapping
{
  public class CatalogMappingProfile : Profile
  {
    public CatalogMappingProfile()
    {
      var map = CreateMap<Culture, CultureModel>();
      map.ForMember(dest => dest.Description, opt => opt.MapFrom (src =>  src.Description.Value));
    }
  }
}
