using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data ;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public MoviesController(ApiDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetItems() {
            var movies = await _context.Movies.ToListAsync();
            return Ok(movies);
        }

        [HttpPost]
        public async Task<ActionResult> CreateItem(MoviesData data) {
            if (ModelState.IsValid) {
                await _context.Movies.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.id}, data);
            }

            return new JsonResult("Something went wrong") {StatusCode = 500} ;
        }

         [HttpGet("{id}")]
        public async Task<ActionResult> GetItem(int id) {
            var item = await _context.Movies.FirstOrDefaultAsync(x => x.id == id);

            if(item == null) {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")]
         public async Task<ActionResult> UpdateItem(int id, MoviesData item) {
            if(id != item.id) {
                return BadRequest();
            }
            
            var existItem = await _context.Movies.FirstOrDefaultAsync(x => x.id == id);
            
            if(existItem == null) {
                return NotFound();
            }

            existItem.name = item.name;
            existItem.genre = item.genre;
            existItem.duration = item.duration;
            existItem.releasedate = item.releasedate;

            await _context.SaveChangesAsync();
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteItem(int id) {
           var existItem = await _context.Movies.FirstOrDefaultAsync(x => x.id == id);
            
            if(existItem == null) {
                return NotFound();
            }

            _context.Movies.Remove(existItem);
            await _context.SaveChangesAsync();
            return Ok(existItem);
        }        
    }
}


