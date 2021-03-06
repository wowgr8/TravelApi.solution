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
    public async Task<ActionResult<IEnumerable<Destination>>> Get(string country, string city, int minRating, int destinationid)
    {
      // var query = _db.Destinations.AsQueryable();

      IQueryable<Destination> query = _db.Destinations.AsQueryable();

      if(country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }

      if(city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      if(destinationid != null)
      {
        query = query.Where(entry => entry.DestinationId == destinationid);
      }

      if (minRating > 0)
      {
        query = query.Where(entry => entry.Rating >= minRating);
      }

      return await query.ToListAsync();
    }

    // GET: api/Destinations/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Destination>> GetDestination(int id)
    {
        var destination = await _db.Destinations.FindAsync(id);

        if (destination == null)
        {
            return NotFound();
        }

        return destination;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Destination destination)
    {
      if (id != destination.DestinationId)
      {
        return BadRequest();
      }

      _db.Entry(destination).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DestinationExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    // POST: api/Destinations
    [HttpPost]
    public async Task<ActionResult<Destination>> Post(Destination destination)
    {
      _db.Destinations.Add(destination);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetDestination), new { id = destination.DestinationId }, destination);
    }

    
    // DELETE: api/Destinations/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDestination(int id)
    {
      var destination = await _db.Destinations.FindAsync(id);
      if (destination == null)
      {
        return NotFound();
      }

      _db.Destinations.Remove(destination);
      await _db.SaveChangesAsync();

      return NoContent();
    }
        
    private bool DestinationExists (int id)
    {
      return _db.Destinations.Any(e => e.DestinationId == id);
    }
  }
}

