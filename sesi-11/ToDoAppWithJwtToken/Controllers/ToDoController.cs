using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using TodoApp.Data;
using TodoApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace TodoApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TodoController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public TodoController(ApiDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetItems() {
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<ActionResult> CreateItem(ItemData data) {
            if (ModelState.IsValid) {
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.id}, data);
            }

            return new JsonResult("Something went wrong") {StatusCode = 500} ;
        }

         [HttpGet("{id}")]
        public async Task<ActionResult> GetItem(int id) {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.id == id);

            if(item == null) {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")]
         public async Task<ActionResult> UpdateItem(int id, ItemData item) {
            if(id != item.id) {
                return BadRequest();
            }
            
            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.id == id);
            
            if(existItem == null) {
                return NotFound();
            }

            existItem.title = item.title;
            existItem.description = item.description;
            existItem.done = item.done;

            await _context.SaveChangesAsync();
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteItem(int id) {
           var existItem = await _context.Items.FirstOrDefaultAsync(x => x.id == id);
            
            if(existItem == null) {
                return NotFound();
            }

            _context.Items.Remove(existItem);
            await _context.SaveChangesAsync();
            return Ok(existItem);
        }        
    }
}


