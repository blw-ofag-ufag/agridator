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
    public IActionResult GetTypeOfWorkList()
    {
      throw new NotImplementedException();
    }

    [HttpGet("UsageTypes")]
    public IActionResult GetUseageTypes ()
    {
      throw new NotImplementedException ();
    }

    [HttpGet ("PlantProtectionProducts")]
    public IActionResult GetPlantProtectionProducts ()
    { 
      throw new NotImplementedException ();
    }

    [HttpGet ("Fertilizers")]
    public IActionResult GetFertilizers ()
    {
      throw new NotImplementedException ();
    }

    [HttpGet ("Cultures")]
    public async Task<IActionResult> GetCultrues ()
    {
      var culturesFromDB = await _dbContext.Cultures.ToListAsync().ConfigureAwait (false);
      return Ok (_mapper.Map<IEnumerable<CultureModel>> (culturesFromDB));
    }

    [HttpGet ("CultureCategories")]
    public IActionResult GetCultureCategories ()
    {
      throw new NotImplementedException ();
    }
  }
}
