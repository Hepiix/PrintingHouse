using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrintingHouseBackend.Migrations
{
    /// <inheritdoc />
    public partial class NewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Company", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 1, "Courtesy Hardware Store", "Steven", "7815219682", "Waters" },
                    { 2, "Friendly Advice", "Matthew", "6209959419", "Clark" },
                    { 3, "Peaches", "Robert", "4026489114", "Phillips" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Name", "Pattern" },
                values: new object[,]
                {
                    { 1, "SW. Courtesy Hardward Store", "swchs12" },
                    { 2, "MC. Friendly Advice", "mcfa3" },
                    { 3, "RP. Peaches", "rpp1" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateOnly(2024, 2, 12), false },
                    { 2, 2, new DateOnly(2024, 6, 1), false },
                    { 3, 3, new DateOnly(2023, 7, 27), true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
