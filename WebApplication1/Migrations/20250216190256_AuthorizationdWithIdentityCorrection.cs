using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AuthorizationdWithIdentityCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 11, 2, 55, 682, DateTimeKind.Local).AddTicks(1068), new DateTime(2025, 2, 16, 11, 2, 55, 682, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 16, 11, 2, 55, 682, DateTimeKind.Local).AddTicks(1116), new DateTime(2025, 2, 16, 11, 2, 55, 682, DateTimeKind.Local).AddTicks(1118) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
