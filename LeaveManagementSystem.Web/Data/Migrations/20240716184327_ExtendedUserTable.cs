using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cc21aa9-357b-459d-9287-4d0faf140034",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", 
                    "SecurityStamp" },
                values: new object[] { "4552c445-61ad-4a98-a7d3-bf764b7bc759", new DateOnly(1985, 11, 30),
                    "Default", "Admin", "AQAAAAIAAYagAAAAEOt7IpitOTdngxe11oCccPtKEmRmJa6M7eoHkvSimk9DYYmD2VM2+A2BWmn9uVcIgg==", 
                    "22aba069-8ccc-4835-b06e-54f445dd75ee" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cc21aa9-357b-459d-9287-4d0faf140034",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cfd9167-bf06-441f-86a3-2819e083c617", "AQAAAAIAAYagAAAAEFBRMXXni3kcxQTdpbHw2vbtX2+tBrjPnaSRm+GHoUErWqaiScv5wtzZrI4fkD/wow==", "c749bf4b-5008-48c6-82d7-4651bfe29acb" });
        }
    }
}
