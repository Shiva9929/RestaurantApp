using System;

namespace RestaurantApp.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public int Rating { get; set; }
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    }
}
