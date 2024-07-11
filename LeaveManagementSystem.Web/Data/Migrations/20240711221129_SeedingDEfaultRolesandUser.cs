using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDEfaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26e8fd60-aa62-4a31-820b-1dc183fa42f3", null, "Supervior", "SUPERVISOR" },
                    { "79b38cac-6d0d-4eb8-bcb9-8ccff0d30dfc", null, "Employee", "EMPLOYEE" },
                    { "d3e226c4-0929-47fb-8169-ff3ecc9db83d", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed",
                    "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash",
                    "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3cc21aa9-357b-459d-9287-4d0faf140034", 0,
                    "8cfd9167-bf06-441f-86a3-2819e083c617", "admin@localhost.com", true, false, null,
                    "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM",
                    "AQAAAAIAAYagAAAAEFBRMXXni3kcxQTdpbHw2vbtX2+tBrjPnaSRm+GHoUErWqaiScv5wtzZrI4fkD/wow==",
                    null, false, "c749bf4b-5008-48c6-82d7-4651bfe29acb", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d3e226c4-0929-47fb-8169-ff3ecc9db83d", "3cc21aa9-357b-459d-9287-4d0faf140034" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26e8fd60-aa62-4a31-820b-1dc183fa42f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79b38cac-6d0d-4eb8-bcb9-8ccff0d30dfc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3e226c4-0929-47fb-8169-ff3ecc9db83d", "3cc21aa9-357b-459d-9287-4d0faf140034" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3e226c4-0929-47fb-8169-ff3ecc9db83d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cc21aa9-357b-459d-9287-4d0faf140034");
        }
    }
}
