using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class addedseeduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d68d3885-4dbb-4ba5-861b-0409a5c2d95a", 0, "5c993eb7-de26-48b2-95fc-ca47790b4d18", "meow@meow.com", true, false, null, "MEOW@MEOW.COM", "MEOW@MEOW.COM", "AQAAAAIAAYagAAAAEF7qWJNfox3I5ZuCjNpTMLRxnaithyiGXvFnJX7YE4BoWGbOp48L9AFf9kNOfniSqg==", null, false, "4be265e9-4327-4469-9af7-2ce54648b9dd", false, "meow@meow.com" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 1,
                columns: new[] { "Author", "CreatedDate", "UpdatedDate" },
                values: new object[] { "d68d3885-4dbb-4ba5-861b-0409a5c2d95a", new DateTime(2025, 2, 16, 11, 35, 12, 917, DateTimeKind.Local).AddTicks(3036), new DateTime(2025, 2, 16, 11, 35, 12, 917, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 11, 35, 12, 917, DateTimeKind.Local).AddTicks(3101), new DateTime(2025, 2, 16, 11, 35, 12, 917, DateTimeKind.Local).AddTicks(3103) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68d3885-4dbb-4ba5-861b-0409a5c2d95a");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 1,
                columns: new[] { "Author", "CreatedDate", "UpdatedDate" },
                values: new object[] { "Will", new DateTime(2025, 2, 16, 11, 2, 55, 682, DateTimeKind.Local).AddTicks(1068), new DateTime(2025, 2, 16, 11, 2, 55, 682, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 11, 2, 55, 682, DateTimeKind.Local).AddTicks(1116), new DateTime(2025, 2, 16, 11, 2, 55, 682, DateTimeKind.Local).AddTicks(1118) });
        }
    }
}
