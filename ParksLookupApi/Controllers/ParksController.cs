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
    }
}