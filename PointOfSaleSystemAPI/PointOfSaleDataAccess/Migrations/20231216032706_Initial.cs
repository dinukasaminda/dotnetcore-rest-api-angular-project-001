using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PointOfSaleDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarcodePrefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarcodePrefix", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, "1001", new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6239), "Product 1", new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6249) },
                    { 2L, "1002", new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6251), "Product 2", new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6251) },
                    { 3L, "1003", new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6253), "Product 3", new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6253) },
                    { 4L, "1004", new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6255), "Product 4", new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6255) },
                    { 5L, "1005", new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6256), "Product 5", new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6257) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
