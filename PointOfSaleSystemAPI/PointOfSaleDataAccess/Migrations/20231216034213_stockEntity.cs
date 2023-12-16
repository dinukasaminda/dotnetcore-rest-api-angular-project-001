using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PointOfSaleDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class stockEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitCost = table.Column<double>(type: "float", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    BarcodePrefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2078), new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2090), new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2092), new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2094), new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2096), new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "BarcodePrefix", "CreatedDate", "ProductId", "Quantity", "UnitCost", "UnitPrice", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, "X1", new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2241), 1L, 10, 123.34, 125.34, new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2242) },
                    { 2L, "X2", new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2245), 2L, 10, 12.09, 14.09, new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2245) },
                    { 3L, "X3", new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2247), 3L, 100, 2.0, 4.0, new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2248) },
                    { 4L, "X4", new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2249), 4L, 1000, 500.0, 600.0, new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2250) },
                    { 5L, "X5", new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2251), 5L, 5, 124.0, 126.0, new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2252) },
                    { 6L, "X11", new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2253), 1L, 35, 126.34, 128.34, new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2254) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6251), new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6255), new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6256), new DateTime(2023, 12, 16, 8, 57, 6, 326, DateTimeKind.Local).AddTicks(6257) });
        }
    }
}
