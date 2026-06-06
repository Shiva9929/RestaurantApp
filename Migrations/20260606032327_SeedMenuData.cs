using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedMenuData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "IsAvailable", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Main Course", new DateTime(2026, 6, 6, 3, 23, 27, 527, DateTimeKind.Utc).AddTicks(4410), "Crispy chicken burger with lettuce and sauce", true, "Chicken Burger", 12.99m },
                    { 2, "Main Course", new DateTime(2026, 6, 6, 3, 23, 27, 527, DateTimeKind.Utc).AddTicks(5010), "Classic pizza with tomato sauce and mozzarella", true, "Margherita Pizza", 14.99m },
                    { 3, "Main Course", new DateTime(2026, 6, 6, 3, 23, 27, 527, DateTimeKind.Utc).AddTicks(5010), "Fresh Atlantic salmon with lemon butter sauce", true, "Grilled Salmon", 22.99m },
                    { 4, "Main Course", new DateTime(2026, 6, 6, 3, 23, 27, 527, DateTimeKind.Utc).AddTicks(5010), "Creamy pasta with bacon, eggs and parmesan", true, "Pasta Carbonara", 13.99m },
                    { 5, "Starter", new DateTime(2026, 6, 6, 3, 23, 27, 527, DateTimeKind.Utc).AddTicks(5010), "Fresh romaine lettuce with caesar dressing and croutons", true, "Caesar Salad", 8.99m },
                    { 6, "Starter", new DateTime(2026, 6, 6, 3, 23, 27, 527, DateTimeKind.Utc).AddTicks(5020), "Crispy garlic bread with herb butter", true, "Garlic Bread", 4.99m },
                    { 7, "Dessert", new DateTime(2026, 6, 6, 3, 23, 27, 527, DateTimeKind.Utc).AddTicks(5020), "Warm chocolate brownie with vanilla ice cream", true, "Chocolate Brownie", 6.99m },
                    { 8, "Dessert", new DateTime(2026, 6, 6, 3, 23, 27, 527, DateTimeKind.Utc).AddTicks(5020), "Classic Italian dessert with coffee and mascarpone", true, "Tiramisu", 7.99m },
                    { 9, "Drink", new DateTime(2026, 6, 6, 3, 23, 27, 527, DateTimeKind.Utc).AddTicks(5020), "Fresh squeezed mango juice", true, "Mango Juice", 3.99m },
                    { 10, "Drink", new DateTime(2026, 6, 6, 3, 23, 27, 527, DateTimeKind.Utc).AddTicks(5020), "Freshly squeezed lemonade with mint", true, "Fresh Lemonade", 4.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
