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
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComapnyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StockBarcodePrefix = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TotalItemCost = table.Column<double>(type: "float", nullable: false),
                    OtherCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BarcodePrefix = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceStocks",
                columns: table => new
                {
                    StockId = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceStocks", x => new { x.InvoiceId, x.StockId });
                    table.ForeignKey(
                        name: "FK_InvoiceStocks_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    Type = table.Column<int>(type: "int", nullable: false),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarcodePrefix", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, "1001", new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(1897), "Product 1", new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(1914) },
                    { 2L, "1002", new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(1916), "Product 2", new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(1917) },
                    { 3L, "1003", new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(1918), "Product 3", new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(1919) },
                    { 4L, "1004", new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(1920), "Product 4", new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(1921) },
                    { 5L, "1005", new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(1922), "Product 5", new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(1923) }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "ActionType", "CreatedDate", "ProductId", "Quantity", "Type", "UnitCost", "UnitPrice" },
                values: new object[,]
                {
                    { 1L, 0, new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(2066), 1L, 10, 0, 123.34, 125.34 },
                    { 2L, 0, new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(2069), 2L, 10, 0, 12.09, 14.09 },
                    { 3L, 0, new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(2071), 3L, 100, 0, 2.0, 4.0 },
                    { 4L, 0, new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(2073), 4L, 1000, 0, 500.0, 600.0 },
                    { 5L, 0, new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(2074), 5L, 5, 0, 124.0, 126.0 },
                    { 6L, 0, new DateTime(2023, 12, 18, 9, 55, 57, 458, DateTimeKind.Local).AddTicks(2075), 1L, 35, 0, 126.34, 128.34 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_StockBarcodePrefix",
                table: "Invoices",
                column: "StockBarcodePrefix",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceStocks");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
