using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookupApi.Models;


namespace ParksLookupApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private readonly ParksLookupApiContext _db;

        public ParksController(ParksLookupApiContext db)
        {
            _db = db;
        }

        // GET: api/Parks
        [HttpGet]
        [Authorize]
        public async Task<List<Park>> Get(string name, string state, int yearOfEstablishment)
        {
            IQueryable<Park> query = _db.Parks.AsQueryable();

            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }

            if (state != null)
            {
                query = query.Where(entry => entry.State.Contains(state));
            }

            if (yearOfEstablishment > 1700)
            {
                query = query.Where(entry => entry.YearOfEstablishment == yearOfEstablishment);
            }

            return await query.ToListAsync();
        }


        // GET: api/Parks/5
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

        // PUT: api/Parks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Park park)
        {
            if (id != park.ParkId)
            {
                return BadRequest();
            }

            _db.Entry(park).State = EntityState.Modified;

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

        // POST: api/Parks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Park>> Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetPark", new { id = park.ParkId }, park);
        }

        // // DELETE: api/Parks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePark(int id)
        {
            Park park = await _db.Parks.FindAsync(id);
            if (park == null)
            {
                return NotFound();
            }

            _db.Parks.Remove(park);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool ParkExists(int id)
        {
            return _db.Parks.Any(e => e.ParkId == id);
        }
    }
}