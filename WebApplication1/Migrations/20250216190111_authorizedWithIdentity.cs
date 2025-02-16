using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class authorizedWithIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 11, 1, 10, 944, DateTimeKind.Local).AddTicks(6862), new DateTime(2025, 2, 16, 11, 1, 10, 944, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 11, 1, 10, 944, DateTimeKind.Local).AddTicks(6919), new DateTime(2025, 2, 16, 11, 1, 10, 944, DateTimeKind.Local).AddTicks(6921) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 10, 40, 16, 370, DateTimeKind.Local).AddTicks(2361), new DateTime(2025, 2, 16, 10, 40, 16, 370, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 10, 40, 16, 370, DateTimeKind.Local).AddTicks(2410), new DateTime(2025, 2, 16, 10, 40, 16, 370, DateTimeKind.Local).AddTicks(2411) });
        }
    }
}
