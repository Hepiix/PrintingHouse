using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrintingHouseBackend.Migrations
{
    /// <inheritdoc />
    public partial class newModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "JobsOrders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryMethod",
                table: "JobsOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "JobsOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ColorMode",
                table: "JobsDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dimensions",
                table: "JobsDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaperType",
                table: "JobsDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrintSides",
                table: "JobsDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "JobsDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "JobsDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "JobsDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "JobsDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Company", "Country", "Email", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress", "Surname" },
                values: new object[] { "New York", "Doe Designs", "USA", "john.doe@doedesigns.com", "John", "+1-123-456-7890", "10001", "NY", "123 Main St", "Doe" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Company", "Country", "Email", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress", "Surname" },
                values: new object[] { "Los Angeles", "Smith Printing Co.", "USA", "jane.smith@smithprinting.com", "Jane", "+1-987-654-3210", "90001", "CA", "456 Elm St", "Smith" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Company", "Country", "Email", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress", "Surname" },
                values: new object[] { "Miami", "Gonzalez Graphics", "USA", "maria.gonzalez@gonzalezgraphics.com", "Maria", "+1-555-123-4567", "33101", "FL", "789 Oak St", "Gonzalez" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "City", "Company", "Country", "Email", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress", "Surname" },
                values: new object[,]
                {
                    { 4, "London", null, "UK", "liam.brown@example.co.uk", "Liam", "+44-20-7946-0958", "SW1A 2AA", "England", "10 Downing Street", "Brown" },
                    { 5, "Sydney", "Taylor Marketing", "Australia", "emily.taylor@taylormarketing.au", "Emily", "+61-2-9374-4000", "2000", "NSW", "100 George St", "Taylor" }
                });

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorMode", "Dimensions", "Name", "PaperType", "Pattern", "PrintSides", "Quantity", "Status", "TotalPrice", "UnitPrice" },
                values: new object[] { "Full Color", "3.5x2 inches", "Business Cards", "Glossy", "BC-001", "Double", 500, "Pending", 100.00m, 0.20m });

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColorMode", "Dimensions", "Name", "PaperType", "Pattern", "PrintSides", "Quantity", "Status", "TotalPrice", "UnitPrice" },
                values: new object[] { "Full Color", "8.5x11 inches", "Flyers", "Matte", "FL-002", "Single", 1000, "In Progress", 150.00m, 0.15m });

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorMode", "Dimensions", "Name", "PaperType", "Pattern", "PrintSides", "Quantity", "Status", "TotalPrice", "UnitPrice" },
                values: new object[] { "Full Color", "18x24 inches", "Posters", "Satin", "PO-003", "Single", 200, "Completed", 500.00m, 2.50m });

            migrationBuilder.InsertData(
                table: "JobsDetails",
                columns: new[] { "Id", "ColorMode", "Dimensions", "Name", "PaperType", "Pattern", "PrintSides", "Quantity", "Status", "TotalPrice", "UnitPrice" },
                values: new object[,]
                {
                    { 4, "Full Color", "8.5x11 inches", "Brochures", "Glossy", "BR-004", "Double", 300, "Pending", 300.00m, 1.00m },
                    { 5, "Full Color", "4x4 inches", "Stickers", "Vinyl", "ST-005", "Single", 1000, "In Progress", 500.00m, 0.50m }
                });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryMethod", "OrderDate", "OrderNumber", "Status" },
                values: new object[] { "Courier", new DateOnly(2024, 9, 20), "ORD-001", "Pending" });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryMethod", "OrderDate", "OrderNumber", "Status" },
                values: new object[] { "Self Pickup", new DateOnly(2024, 9, 21), "ORD-002", "In Progress" });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryMethod", "OrderDate", "OrderNumber", "Status" },
                values: new object[] { "Courier", new DateOnly(2024, 9, 22), "ORD-003", "Completed" });

            migrationBuilder.InsertData(
                table: "JobsOrders",
                columns: new[] { "Id", "CustomerId", "DeliveryMethod", "JobDetailsId", "OrderDate", "OrderNumber", "Status" },
                values: new object[,]
                {
                    { 4, 4, "Courier", 4, new DateOnly(2024, 9, 23), "ORD-004", "Pending" },
                    { 5, 5, "Courier", 5, new DateOnly(2024, 9, 24), "ORD-005", "In Progress" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "DeliveryMethod",
                table: "JobsOrders");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "JobsOrders");

            migrationBuilder.DropColumn(
                name: "ColorMode",
                table: "JobsDetails");

            migrationBuilder.DropColumn(
                name: "Dimensions",
                table: "JobsDetails");

            migrationBuilder.DropColumn(
                name: "PaperType",
                table: "JobsDetails");

            migrationBuilder.DropColumn(
                name: "PrintSides",
                table: "JobsDetails");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "JobsDetails");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "JobsDetails");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "JobsDetails");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "JobsDetails");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "Customers");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "JobsOrders",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Company", "Name", "PhoneNumber", "Surname" },
                values: new object[] { "Courtesy Hardware Store", "Steven", "7815219682", "Waters" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Company", "Name", "PhoneNumber", "Surname" },
                values: new object[] { "Friendly Advice", "Matthew", "6209959419", "Clark" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Company", "Name", "PhoneNumber", "Surname" },
                values: new object[] { "Peaches", "Robert", "4026489114", "Phillips" });

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Pattern" },
                values: new object[] { "SW. Courtesy Hardward Store", "swchs12" });

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Pattern" },
                values: new object[] { "MC. Friendly Advice", "mcfa3" });

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Pattern" },
                values: new object[] { "RP. Peaches", "rpp1" });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderDate", "Status" },
                values: new object[] { new DateOnly(2024, 2, 12), false });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderDate", "Status" },
                values: new object[] { new DateOnly(2024, 6, 1), false });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OrderDate", "Status" },
                values: new object[] { new DateOnly(2023, 7, 27), true });
        }
    }
}
