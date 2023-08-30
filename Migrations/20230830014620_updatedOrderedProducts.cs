using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BangazonBackend.Migrations
{
    public partial class updatedOrderedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OrderedProducts",
                columns: new[] { "OrderId", "ProductId", "Id" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 8, 29, 20, 46, 20, 64, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 8, 29, 20, 46, 20, 64, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 8, 29, 20, 46, 20, 64, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 8, 29, 20, 46, 20, 64, DateTimeKind.Local).AddTicks(3778));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderedProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 8, 28, 21, 20, 58, 402, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 8, 28, 21, 20, 58, 402, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 8, 28, 21, 20, 58, 402, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 8, 28, 21, 20, 58, 402, DateTimeKind.Local).AddTicks(4576));
        }
    }
}
