using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrintingHouseBackend.Migrations
{
    /// <inheritdoc />
    public partial class UserLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersData", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UsersData",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "jeremy20110@yahoo.com", "Jeri", "Medlin", "123" },
                    { 2, "heber_barte@gmail.com", "Cynthia", "Chamberlain", "123" },
                    { 3, "bettie1995@hotmail.com", "Justin", "Smith", "123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersData");
        }
    }
}
