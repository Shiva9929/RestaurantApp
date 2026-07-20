using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantApp.Data;
using RestaurantApp.Models;

namespace RestaurantApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly RestaurantDbContext _context;

        public FeedbackController(RestaurantDbContext context)
        {
            _context = context;
        }

        // GET all feedback
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var feedback = await _context.Feedbacks
                .OrderByDescending(f => f.SubmittedAt)
                .ToListAsync();
            return Ok(feedback);
        }

        // POST submit feedback
        [HttpPost]
        public async Task<IActionResult> Submit(Feedback feedback)
        {
            if (feedback.Rating < 1 || feedback.Rating > 5)
                return BadRequest("Rating must be between 1 and 5");

            feedback.SubmittedAt = DateTime.UtcNow;
            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
            return Ok(feedback);
        }
    }
}