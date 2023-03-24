using Agridator.Web.Data.Entities;
using Agridator.Web.Models;
using AutoMapper;

namespace Agridator.Web.Mapping
{
  public class CatalogMappingProfile : Profile
  {
    public CatalogMappingProfile()
    {
      var cultureMap = CreateMap<Culture, CultureModel>();
      cultureMap.ForMember(dest => dest.Description, opt => opt.MapFrom (src =>  src.Description.Value));

      var cultureCategoryMap = CreateMap<CultureCategory, CultureCategoryModel>();
      cultureCategoryMap.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description.Value));

      var fertilizerMap = CreateMap<Fertilizer, FertilizerModel>();
      fertilizerMap.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description.Value));

      CreateMap<PlantProtectionProduct, PlantProtectionProductModel>();

      CreateMap<TypeOfWork, TypeOfWorkModel>();

      var usageTypesFromDB = CreateMap<UsageType, UsageTypeModel>();
      usageTypesFromDB.ForMember(dest => dest.Nutzung, opt => opt.MapFrom(src => src.Nutzung.Value));
    }
  }
}
