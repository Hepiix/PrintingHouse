using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrintingHouseBackend.Migrations
{
    /// <inheritdoc />
    public partial class newModels3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "JobsDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "JobsDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "In Progress");

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: "Completed");

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "JobsDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "Status",
                value: "In Progress");
        }
    }
}
