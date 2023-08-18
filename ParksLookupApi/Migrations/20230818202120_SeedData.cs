using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksLookupApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfEstablishment",
                table: "Parks");

            migrationBuilder.AddColumn<int>(
                name: "YearOfEstablishment",
                table: "Parks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Designation", "Name", "State", "YearOfEstablishment" },
                values: new object[,]
                {
                    { 1, "State Park", "Custer State Park", "South Dakota", 1919 },
                    { 2, "National Park", "Acadia National Park", "Maine", 1919 },
                    { 3, "National Park", "Canyonlands National Park", "Utah", 1964 },
                    { 4, "National Historical Park", "Valley Forge National Historical Park", "Pennsylvania", 1976 },
                    { 5, "National Seashore", "Cape Hatteras National Seashore", "North Carolina", 1937 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "YearOfEstablishment",
                table: "Parks");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfEstablishment",
                table: "Parks",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
