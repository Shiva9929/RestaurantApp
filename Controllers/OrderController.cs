using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantApp.Data;
using RestaurantApp.Models;

namespace RestaurantApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly RestaurantDbContext _context;

        public OrderController(RestaurantDbContext context)
        {
            _context = context;
        }

        // GET all orders
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _context.Orders
                .Include(o => o.MenuItem)
                .ToListAsync();
            return Ok(orders);
        }

        // POST place new order
        [HttpPost]
        public async Task<IActionResult> PlaceOrder(Order order)
        {
            var menuItem = await _context.MenuItems
                .FindAsync(order.MenuItemId);
            if (menuItem == null)
                return NotFound("Menu item not found");

            order.TotalPrice = menuItem.Price * order.Quantity;
            order.Status = "Pending";
            order.OrderedAt = DateTime.UtcNow;

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return Ok(order);
        }

        // PUT update order status
        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateStatus(
            int id, [FromBody] string status)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
                return NotFound("Order not found");

            order.Status = status;
            await _context.SaveChangesAsync();
            return Ok(order);
        }
    }
}