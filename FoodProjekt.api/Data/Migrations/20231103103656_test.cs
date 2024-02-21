using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodProjekt.api.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValidTill",
                value: new DateTime(2023, 11, 10, 11, 36, 55, 979, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4,
                column: "ValidTill",
                value: new DateTime(2023, 11, 5, 11, 36, 55, 979, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 5,
                column: "ValidTill",
                value: new DateTime(2023, 11, 7, 11, 36, 55, 979, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 6,
                column: "ValidTill",
                value: new DateTime(2023, 12, 3, 11, 36, 55, 979, DateTimeKind.Local).AddTicks(9724));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValidTill",
                value: new DateTime(2023, 11, 10, 0, 27, 40, 252, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4,
                column: "ValidTill",
                value: new DateTime(2023, 11, 5, 0, 27, 40, 252, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 5,
                column: "ValidTill",
                value: new DateTime(2023, 11, 7, 0, 27, 40, 252, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 6,
                column: "ValidTill",
                value: new DateTime(2023, 12, 3, 0, 27, 40, 252, DateTimeKind.Local).AddTicks(2165));
        }
    }
}
