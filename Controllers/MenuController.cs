using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantApp.Data;
using RestaurantApp.Models;

namespace RestaurantApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly RestaurantDbContext _context;

        public MenuController(RestaurantDbContext context)
        {
            _context = context;
        }

        // GET all menu items
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _context.MenuItems.ToListAsync();
            return Ok(items);
        }

        // GET single menu item
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _context.MenuItems.FindAsync(id);
            if (item == null)
                return NotFound("Menu item not found");
            return Ok(item);
        }

        // POST create new menu item
        [HttpPost]
        public async Task<IActionResult> Create(MenuItem item)
        {
            _context.MenuItems.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), 
                new { id = item.Id }, item);
        }

        // PUT update menu item
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, MenuItem updated)
        {
            var item = await _context.MenuItems.FindAsync(id);
            if (item == null)
                return NotFound("Menu item not found");

            item.Name = updated.Name;
            item.Description = updated.Description;
            item.Price = updated.Price;
            item.Category = updated.Category;
            item.IsAvailable = updated.IsAvailable;

            await _context.SaveChangesAsync();
            return Ok(item);
        }

        // DELETE menu item
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.MenuItems.FindAsync(id);
            if (item == null)
                return NotFound("Menu item not found");

            _context.MenuItems.Remove(item);
            await _context.SaveChangesAsync();
            return Ok("Menu item deleted successfully");
        }
    }
}