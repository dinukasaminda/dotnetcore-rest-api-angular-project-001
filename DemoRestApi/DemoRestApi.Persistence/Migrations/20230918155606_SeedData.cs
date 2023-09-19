using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoRestApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, new DateTime(2023, 9, 18, 21, 26, 6, 940, DateTimeKind.Local).AddTicks(8710), "sample 2", new DateTime(2023, 9, 20, 21, 26, 6, 940, DateTimeKind.Local).AddTicks(8740), 1, "Collect letters" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
