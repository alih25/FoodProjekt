using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodProjekt.api.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    OfferedValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ValidTill = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "burgers.png", "Burgers" },
                    { 2, "dessert.png", "Desserts" },
                    { 3, "drinks.png", "Drinks" },
                    { 4, "pizza.png", "Pizza" },
                    { 5, "seafood.png", "Seafood" },
                    { 6, "soup.png", "Soups" },
                    { 7, "veg.png", "Vegetarian" }
                });

            migrationBuilder.InsertData(
                table: "Offer",
                columns: new[] { "Id", "Code", "Description", "Image", "IsActive", "MinAmount", "Name", "OfferedValue", "Type", "ValidTill" },
                values: new object[,]
                {
                    { 1, "OFF-50", "50 Percent on all food types", "femtio.png", true, null, "50 Percent Off", 50m, 1, new DateTime(2023, 11, 10, 0, 27, 40, 252, DateTimeKind.Local).AddTicks(2118) },
                    { 2, "SPEC-150", "Special offer on all food types", "special.png", true, null, "Special Offer", 150m, 0, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, "UPTO-50", "Upto 50% OFF", "upto50.png", true, 500m, "Upto 50% OFF", 50m, 1, null },
                    { 4, "OFF-70", "70 Percent on all food types", "sjuttio.png", true, null, "70 Percent Off", 70m, 1, new DateTime(2023, 11, 5, 0, 27, 40, 252, DateTimeKind.Local).AddTicks(2162) },
                    { 5, "OFF-40", "40 Percent on all food types", "fyrtio.png", true, null, "40% SALE OFF", 40m, 1, new DateTime(2023, 11, 7, 0, 27, 40, 252, DateTimeKind.Local).AddTicks(2163) },
                    { 6, "OFF-30", "30 Percent on all food types", "trettio.png", true, 300m, "SALE 30% OFF", 30m, 1, new DateTime(2023, 12, 3, 0, 27, 40, 252, DateTimeKind.Local).AddTicks(2165) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Offer");
        }
    }
}
