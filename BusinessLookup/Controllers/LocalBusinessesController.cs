using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLookup.Models;

namespace BusinessLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LocalBusinessesController : ControllerBase
  {
    private readonly BusinessLookupContext _db;

    public LocalBusinessesController(BusinessLookupContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LocalBusiness>>> Get(string businessType, string businessName, string review, int rateReview)
    {
      var query = _db.LocalBusinesses.AsQueryable();
      if (businessType != null)
      {
        query = query.Where(entry => entry.BusinessType == businessType);
      }
      if (businessName != null)
      {
        query = query.Where(entry => entry.BusinessName == businessName);
      }
      if (review != null)
      {
        query = query.Where(entry => entry.Review == review);
      }
      if (rateReview != 0)
      {
        query = query.Where(entry => entry.RateReview == rateReview);
      }
      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LocalBusiness>> GetLocalBusiness(int id)
    {
      var localBusiness = await _db.LocalBusinesses.FindAsync(id);

      if (localBusiness == null)
      {
        return NotFound();
      }

      return localBusiness;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, LocalBusiness localBusiness)
    {
      if (id != localBusiness.LocalBusinessId)
      {
        return BadRequest();
      }
      _db.Entry(localBusiness).State = EntityState.Modified;
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!LocalBusinessExists(id))
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

    [HttpPost]
    public async Task<ActionResult<LocalBusiness>> Post(LocalBusiness localBusiness)
    {
      _db.LocalBusinesses.Add(localBusiness);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetLocalBusiness), new { id = localBusiness.LocalBusinessId }, localBusiness);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteLocalBusiness(int id)
    {
      var localBusiness = await _db.LocalBusinesses.FindAsync(id);
      if (localBusiness == null)
      {
        return NotFound();
      }

      _db.LocalBusinesses.Remove(localBusiness);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool LocalBusinessExists(int id)
    {
      return _db.LocalBusinesses.Any(e => e.LocalBusinessId == id);
    }
  }
}