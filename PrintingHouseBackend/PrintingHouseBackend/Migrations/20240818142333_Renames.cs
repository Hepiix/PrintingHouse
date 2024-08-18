using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrintingHouseBackend.Migrations
{
    /// <inheritdoc />
    public partial class Renames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "JobsOrders");

            migrationBuilder.RenameTable(
                name: "Jobs",
                newName: "JobsDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobsOrders",
                table: "JobsOrders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobsDetails",
                table: "JobsDetails",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JobsOrders",
                table: "JobsOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobsDetails",
                table: "JobsDetails");

            migrationBuilder.RenameTable(
                name: "JobsOrders",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "JobsDetails",
                newName: "Jobs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs",
                column: "Id");
        }
    }
}
