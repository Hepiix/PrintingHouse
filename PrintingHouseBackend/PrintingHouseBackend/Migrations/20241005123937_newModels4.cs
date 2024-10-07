using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrintingHouseBackend.Migrations
{
    /// <inheritdoc />
    public partial class newModels4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "JobsDetails");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "JobsDetails");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "JobsOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "JobsOrders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Quantity", "TotalPrice" },
                values: new object[] { 100, 20m });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Quantity", "TotalPrice" },
                values: new object[] { 100, 15m });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Quantity", "TotalPrice" },
                values: new object[] { 100, 250m });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Quantity", "TotalPrice" },
                values: new object[] { 100, 100m });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Quantity", "TotalPrice" },
                values: new object[] { 100, 50m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "JobsOrders");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "JobsOrders");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "JobsDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "JobsDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Quantity", "TotalPrice" },
                values: new object[] { 500, 100.00m });

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Quantity", "TotalPrice" },
                values: new object[] { 1000, 150.00m });

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Quantity", "TotalPrice" },
                values: new object[] { 200, 500.00m });

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Quantity", "TotalPrice" },
                values: new object[] { 300, 300.00m });

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Quantity", "TotalPrice" },
                values: new object[] { 1000, 500.00m });
        }
    }
}
