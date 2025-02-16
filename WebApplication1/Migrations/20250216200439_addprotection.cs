using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class addprotection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68d3885-4dbb-4ba5-861b-0409a5c2d95a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6dd5b55-a2e0-40cc-813f-9fc4394c20fe", "AQAAAAIAAYagAAAAEOYQ2T2qEZyFGN/2nWtKUSyTWVxb7NQxU3sdcoZJGXPCmK8d+JA4S+BgECZg8Zn0Sg==", "dc491369-be2d-40bf-81ad-4bb2a9109549" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 4, 33, 875, DateTimeKind.Local).AddTicks(2015), new DateTime(2025, 2, 16, 12, 4, 33, 875, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 12, 4, 33, 875, DateTimeKind.Local).AddTicks(2078), new DateTime(2025, 2, 16, 12, 4, 33, 875, DateTimeKind.Local).AddTicks(2080) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68d3885-4dbb-4ba5-861b-0409a5c2d95a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c993eb7-de26-48b2-95fc-ca47790b4d18", "AQAAAAIAAYagAAAAEF7qWJNfox3I5ZuCjNpTMLRxnaithyiGXvFnJX7YE4BoWGbOp48L9AFf9kNOfniSqg==", "4be265e9-4327-4469-9af7-2ce54648b9dd" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 11, 35, 12, 917, DateTimeKind.Local).AddTicks(3036), new DateTime(2025, 2, 16, 11, 35, 12, 917, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 11, 35, 12, 917, DateTimeKind.Local).AddTicks(3101), new DateTime(2025, 2, 16, 11, 35, 12, 917, DateTimeKind.Local).AddTicks(3103) });
        }
    }
}
