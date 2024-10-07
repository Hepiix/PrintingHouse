using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrintingHouseBackend.Migrations
{
    /// <inheritdoc />
    public partial class newdata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "City", "Company", "Country", "Email", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress", "Surname" },
                values: new object[,]
                {
                    { 6, "Springfield", "Doe Inc.", "USA", "john.doe@example.com", "John", "123-456-7890", "62704", "IL", "123 Main St", "Doe" },
                    { 7, "Greenville", "Smith LLC", "USA", "jane.smith@example.com", "Jane", "234-567-8901", "75401", "TX", "456 Oak St", "Smith" },
                    { 8, "Lincoln", "Johnson Co.", "USA", "alice.johnson@example.com", "Alice", "345-678-9012", "68508", "NE", "789 Pine St", "Johnson" },
                    { 9, "Columbus", "Brown Enterprises", "USA", "robert.brown@example.com", "Robert", "456-789-0123", "43215", "OH", "321 Elm St", "Brown" },
                    { 10, "Hartford", "Davis & Co.", "USA", "emily.davis@example.com", "Emily", "567-890-1234", "06103", "CT", "654 Maple Ave", "Davis" },
                    { 11, "Dover", "Clark Industries", "USA", "michael.clark@example.com", "Michael", "678-901-2345", "19901", "DE", "987 Cedar St", "Clark" },
                    { 12, "Bismarck", "Martinez Ltd.", "USA", "sophia.martinez@example.com", "Sophia", "789-012-3456", "58501", "ND", "111 Birch Ln", "Martinez" },
                    { 13, "Denver", "Lewis Brothers", "USA", "james.lewis@example.com", "James", "890-123-4567", "80202", "CO", "222 Spruce St", "Lewis" },
                    { 14, "Phoenix", "Walker Solutions", "USA", "olivia.walker@example.com", "Olivia", "901-234-5678", "85001", "AZ", "333 Ash St", "Walker" },
                    { 15, "Sacramento", "Hall & Partners", "USA", "david.hall@example.com", "David", "012-345-6789", "95814", "CA", "444 Palm Dr", "Hall" },
                    { 16, "Atlanta", "Young Corp.", "USA", "lucas.young@example.com", "Lucas", "321-123-4321", "30303", "GA", "555 Cypress St", "Young" },
                    { 17, "Austin", "King Enterprises", "USA", "mia.king@example.com", "Mia", "432-234-5432", "73301", "TX", "666 Olive St", "King" },
                    { 18, "Las Vegas", "Scott LLC", "USA", "henry.scott@example.com", "Henry", "543-345-6543", "88901", "NV", "777 Pine Rd", "Scott" },
                    { 19, "Miami", "Green Solutions", "USA", "grace.green@example.com", "Grace", "654-456-7654", "33101", "FL", "888 Aspen Ln", "Green" },
                    { 20, "Seattle", "Hill Group", "USA", "ethan.hill@example.com", "Ethan", "765-567-8765", "98101", "WA", "999 Oak Dr", "Hill" },
                    { 21, "Portland", "Adams LLC", "USA", "ava.adams@example.com", "Ava", "876-678-9876", "97201", "OR", "1001 Maple St", "Adams" },
                    { 22, "Chicago", "Nelson Technologies", "USA", "benjamin.nelson@example.com", "Benjamin", "987-789-0987", "60601", "IL", "1102 Willow St", "Nelson" },
                    { 23, "Boston", "Carter Enterprises", "USA", "ella.carter@example.com", "Ella", "098-890-1098", "02108", "MA", "1203 Cedar St", "Carter" },
                    { 24, "New York", "Mitchell Industries", "USA", "daniel.mitchell@example.com", "Daniel", "109-901-2109", "10001", "NY", "1304 Birch Ln", "Mitchell" },
                    { 25, "San Francisco", "Perez & Co.", "USA", "lily.perez@example.com", "Lily", "210-012-3210", "94101", "CA", "1405 Elm St", "Perez" }
                });

            migrationBuilder.InsertData(
                table: "JobsDetails",
                columns: new[] { "Id", "ColorMode", "Dimensions", "Name", "PaperType", "Pattern", "PrintSides", "UnitPrice" },
                values: new object[,]
                {
                    { 6, "Grayscale", "8.5x11 inches", "Letterheads", "Bond", "LH-006", "Single", 0.10m },
                    { 7, "Full Color", "9.5x4.125 inches", "Envelopes", "Standard", "EN-007", "Single", 0.25m },
                    { 8, "Full Color", "3x6 feet", "Banners", "Vinyl", "BA-008", "Single", 15.00m },
                    { 9, "Grayscale", "5x7 inches", "Notepads", "Bond", "NP-009", "Single", 0.50m },
                    { 10, "Duotone", "11x17 inches", "Calendars", "Glossy", "CA-010", "Double", 3.00m }
                });

            migrationBuilder.InsertData(
                table: "JobsOrders",
                columns: new[] { "Id", "CustomerId", "DeliveryMethod", "JobDetailsId", "OrderDate", "Quantity", "Status", "TotalPrice" },
                values: new object[,]
                {
                    { 6, 1, "Courier", 1, new DateOnly(2024, 9, 25), 100, "Completed", 500.50m },
                    { 7, 2, "Pickup", 2, new DateOnly(2024, 9, 30), 200, "Pending", 1000.00m },
                    { 8, 3, "Courier", 3, new DateOnly(2024, 9, 27), 150, "Shipped", 750.75m },
                    { 9, 4, "Courier", 4, new DateOnly(2024, 9, 23), 300, "Completed", 1500.00m },
                    { 10, 5, "Courier", 5, new DateOnly(2024, 10, 2), 250, "Processing", 1250.25m },
                    { 11, 6, "Pickup", 6, new DateOnly(2024, 9, 20), 175, "Shipped", 875.50m },
                    { 12, 7, "Courier", 7, new DateOnly(2024, 10, 3), 100, "Pending", 500.00m },
                    { 13, 8, "Courier", 8, new DateOnly(2024, 9, 28), 220, "Processing", 1100.00m },
                    { 14, 9, "Courier", 9, new DateOnly(2024, 9, 26), 180, "Completed", 900.00m },
                    { 15, 10, "Courier", 10, new DateOnly(2024, 10, 4), 130, "Processing", 650.50m },
                    { 16, 11, "Pickup", 1, new DateOnly(2024, 9, 24), 160, "Completed", 800.00m },
                    { 17, 12, "Courier", 2, new DateOnly(2024, 9, 21), 270, "Shipped", 1350.75m },
                    { 18, 13, "Courier", 3, new DateOnly(2024, 9, 19), 320, "Completed", 1600.00m },
                    { 19, 14, "Pickup", 4, new DateOnly(2024, 9, 17), 140, "Pending", 700.00m },
                    { 20, 15, "Courier", 5, new DateOnly(2024, 9, 29), 190, "Shipped", 950.00m },
                    { 21, 16, "Courier", 6, new DateOnly(2024, 9, 22), 210, "Completed", 1050.00m },
                    { 22, 17, "Courier", 7, new DateOnly(2024, 9, 18), 230, "Processing", 1150.00m },
                    { 23, 18, "Courier", 8, new DateOnly(2024, 9, 15), 300, "Shipped", 1500.00m },
                    { 24, 19, "Courier", 9, new DateOnly(2024, 9, 13), 250, "Pending", 1250.50m },
                    { 25, 20, "Courier", 10, new DateOnly(2024, 9, 11), 120, "Processing", 600.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
