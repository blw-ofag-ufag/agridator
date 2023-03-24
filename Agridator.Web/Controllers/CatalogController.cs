using Agridator.Web.Data;
using Agridator.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agridator.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatalogController : ControllerBase
  {
    private readonly IMapper _mapper;
    private readonly ApplicationDbContext _dbContext;

    public CatalogController(IMapper mapper, ApplicationDbContext dbContext)
    {
      this._mapper = mapper;
      this._dbContext = dbContext;
    }

    [HttpGet ("TypeOfWork")]
    public async Task<IActionResult> GetTypeOfWorkList()
    {
      var typeOfWorksFromDB = await _dbContext.TypeOfWorks.ToListAsync().ConfigureAwait(false);
      return Ok(_mapper.Map<IEnumerable<TypeOfWorkModel>>(typeOfWorksFromDB));
    }

    [HttpGet("UsageTypes")]
    public async Task<IActionResult> GetUseageTypes ()
    {
      var usageTypesFromDB = await _dbContext.UsageTypes.ToListAsync().ConfigureAwait(false);
      return Ok(_mapper.Map<IEnumerable<UsageTypeModel>>(usageTypesFromDB));
    }

    [HttpGet ("PlantProtectionProducts")]
    public async Task<IActionResult> GetPlantProtectionProducts ()
    {
      var plantProtectionProductsFromDB = await _dbContext.PlantProtectionProducts.ToListAsync().ConfigureAwait(false);
      return Ok(_mapper.Map<IEnumerable<PlantProtectionProductModel>>(plantProtectionProductsFromDB));
    }

    [HttpGet ("Fertilizers")]
    public async Task<IActionResult> GetFertilizers ()
    {
      var fertilizersFromDB = await _dbContext.Fertilizers.ToListAsync().ConfigureAwait (false);
      return Ok(_mapper.Map<IEnumerable<FertilizerModel>>(fertilizersFromDB));
    }

    [HttpGet ("Cultures")]
    public async Task<IActionResult> GetCultrues ()
    {
      var culturesFromDB = await _dbContext.Cultures.ToListAsync().ConfigureAwait (false);
      return Ok (_mapper.Map<IEnumerable<CultureModel>> (culturesFromDB));
    }

    [HttpGet ("CultureCategories")]
    public async Task<IActionResult> GetCultureCategories ()
    {
      var cultureCategoriesFromDB = await _dbContext.CultureCategories.ToListAsync().ConfigureAwait(false);
      return Ok(_mapper.Map<IEnumerable<CultureCategoryModel>>(cultureCategoriesFromDB));
    }
  }
}
