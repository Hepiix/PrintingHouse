using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrintingHouseBackend.Migrations
{
    /// <inheritdoc />
    public partial class NewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobDetailsId",
                table: "JobsOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobDetailsId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobDetailsId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobDetailsId",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobDetailsId",
                table: "JobsOrders");
        }
    }
}
