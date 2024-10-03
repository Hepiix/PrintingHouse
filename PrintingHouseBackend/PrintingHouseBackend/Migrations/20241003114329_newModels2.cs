using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrintingHouseBackend.Migrations
{
    /// <inheritdoc />
    public partial class newModels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "JobsOrders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "JobsOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderNumber",
                value: "ORD-001");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderNumber",
                value: "ORD-002");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderNumber",
                value: "ORD-003");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderNumber",
                value: "ORD-004");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderNumber",
                value: "ORD-005");
        }
    }
}
