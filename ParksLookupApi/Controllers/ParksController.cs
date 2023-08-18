using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookupApi.Models;

namespace ParksLookupApi.Controllers
{
    [Route("api/[controller]")]
    public class ParksController : Controller
    {
        private readonly ParksLookupApiContext _db;

        public ParksController(ParksLookupApiContext db)
        {
            _db = db;
        }

        //Get api/Parks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Park>>> Get()
        {
            return await _db.Parks.ToListAsync();
        }

        // Get api/Parks/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Park>> GetPark(int id)
        {
            Park park = await _db.Parks.FindAsync(id);
            if (park == null)
            {
                return NotFound();
            }
            return park;
        }

        //Create a new park
        //POST api/Parks
        public async Task<ActionResult<Park>> Post(Park park)
        {
            _db.Parks.Add(park);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPark), new { id = park.ParkId, park });
        }


        //Edit existing park
        //PUT api/Parks/{id}
        public async Task<ActionResult> Put(int id, Park park)
        {
            if (id != park.ParkId)
            {
                return BadRequest();
            }

            _db.Parks.Update(park);

            try
            {
                await _db.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!ParkExists(id))
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

        private bool ParkExists(int id)
        {
            return _db.Parks.Any(entry => entry.ParkId == id);
        }
    }
}