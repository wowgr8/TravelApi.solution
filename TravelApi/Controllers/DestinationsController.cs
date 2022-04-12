using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private readonly TravelApiContext _db;
    public DestinationsController(TravelApiContext db)
    {
      _db = db;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destination>>> Get(string country, string city)
    {
      var query = _db.Destinations.AsQueryable();
      if(country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }

      if(city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      return await query.ToListAsync();
    }
  }
}