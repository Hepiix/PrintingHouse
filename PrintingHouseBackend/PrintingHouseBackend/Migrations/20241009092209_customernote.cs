using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrintingHouseBackend.Migrations
{
    /// <inheritdoc />
    public partial class customernote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerNote",
                table: "JobsOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CustomerNote",
                value: "Empty");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CustomerNote",
                value: "Empty");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CustomerNote",
                value: "Empty");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CustomerNote",
                value: "Empty");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CustomerNote",
                value: "Empty");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 29) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 10, 4) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 10, 1) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 27) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 10, 6) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 24) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 10, 7) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 10, 2) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 30) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 10, 8) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 28) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 25) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 23) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 21) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 10, 3) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 26) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 22) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 19) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 17) });

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CustomerNote", "OrderDate" },
                values: new object[] { "Empty", new DateOnly(2024, 9, 15) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerNote",
                table: "JobsOrders");

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 25));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 7,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 30));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 8,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 27));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 9,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 23));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 10,
                column: "OrderDate",
                value: new DateOnly(2024, 10, 2));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 11,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 20));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 12,
                column: "OrderDate",
                value: new DateOnly(2024, 10, 3));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 13,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 28));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 14,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 26));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 15,
                column: "OrderDate",
                value: new DateOnly(2024, 10, 4));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 16,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 24));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 17,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 21));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 18,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 19));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 19,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 17));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 20,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 29));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 21,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 22));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 22,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 18));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 23,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 15));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 24,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 13));

            migrationBuilder.UpdateData(
                table: "JobsOrders",
                keyColumn: "Id",
                keyValue: 25,
                column: "OrderDate",
                value: new DateOnly(2024, 9, 11));
        }
    }
}
