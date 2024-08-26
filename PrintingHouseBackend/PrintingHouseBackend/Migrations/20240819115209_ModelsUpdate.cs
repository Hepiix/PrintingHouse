using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrintingHouseBackend.Migrations
{
    /// <inheritdoc />
    public partial class ModelsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_JobsOrders_CustomerId",
                table: "JobsOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobsOrders_JobDetailsId",
                table: "JobsOrders",
                column: "JobDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobsOrders_Customers_CustomerId",
                table: "JobsOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobsOrders_JobsDetails_JobDetailsId",
                table: "JobsOrders",
                column: "JobDetailsId",
                principalTable: "JobsDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobsOrders_Customers_CustomerId",
                table: "JobsOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_JobsOrders_JobsDetails_JobDetailsId",
                table: "JobsOrders");

            migrationBuilder.DropIndex(
                name: "IX_JobsOrders_CustomerId",
                table: "JobsOrders");

            migrationBuilder.DropIndex(
                name: "IX_JobsOrders_JobDetailsId",
                table: "JobsOrders");
        }
    }
}
