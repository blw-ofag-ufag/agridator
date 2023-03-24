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

      var typeOfWorkMap = CreateMap<TypeOfWork, TypeOfWorkModel>();
      typeOfWorkMap.ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title.Value));

      var usageTypesFromDB = CreateMap<UsageType, UsageTypeModel>();
      usageTypesFromDB.ForMember(dest => dest.Nutzung, opt => opt.MapFrom(src => src.Nutzung.Value));
    }
  }
}
