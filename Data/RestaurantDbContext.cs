using Microsoft.EntityFrameworkCore;
using RestaurantApp.Models;

namespace RestaurantApp.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
            : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItem>().HasData(
             new MenuItem { Id = 1, Name = "Chicken Burger", Description = "Crispy chicken burger with lettuce and sauce", Price = 12.99m, Category = "Main Course", IsAvailable = true, CreatedAt = new DateTime(2026, 1, 1) },
             new MenuItem { Id = 2, Name = "Margherita Pizza", Description = "Classic pizza with tomato sauce and mozzarella", Price = 14.99m, Category = "Main Course", IsAvailable = true, CreatedAt = new DateTime(2026, 1, 1) },
             new MenuItem { Id = 3, Name = "Grilled Salmon", Description = "Fresh Atlantic salmon with lemon butter sauce", Price = 22.99m, Category = "Main Course", IsAvailable = true, CreatedAt = new DateTime(2026, 1, 1) },
             new MenuItem { Id = 4, Name = "Pasta Carbonara", Description = "Creamy pasta with bacon, eggs and parmesan", Price = 13.99m, Category = "Main Course", IsAvailable = true, CreatedAt = new DateTime(2026, 1, 1) },
             new MenuItem { Id = 5, Name = "Caesar Salad", Description = "Fresh romaine lettuce with caesar dressing and croutons", Price = 8.99m, Category = "Starter", IsAvailable = true, CreatedAt = new DateTime(2026, 1, 1) },
             new MenuItem { Id = 6, Name = "Garlic Bread", Description = "Crispy garlic bread with herb butter", Price = 4.99m, Category = "Starter", IsAvailable = true, CreatedAt = new DateTime(2026, 1, 1) },
             new MenuItem { Id = 7, Name = "Chocolate Brownie", Description = "Warm chocolate brownie with vanilla ice cream", Price = 6.99m, Category = "Dessert", IsAvailable = true, CreatedAt = new DateTime(2026, 1, 1) },
             new MenuItem { Id = 8, Name = "Tiramisu", Description = "Classic Italian dessert with coffee and mascarpone", Price = 7.99m, Category = "Dessert", IsAvailable = true, CreatedAt = new DateTime(2026, 1, 1) },
             new MenuItem { Id = 9, Name = "Mango Juice", Description = "Fresh squeezed mango juice", Price = 3.99m, Category = "Drink", IsAvailable = true, CreatedAt = new DateTime(2026, 1, 1) },
             new MenuItem { Id = 10, Name = "Fresh Lemonade", Description = "Freshly squeezed lemonade with mint", Price = 4.99m, Category = "Drink", IsAvailable = true, CreatedAt = new DateTime(2026, 1, 1) }
            );
        }
    }
}