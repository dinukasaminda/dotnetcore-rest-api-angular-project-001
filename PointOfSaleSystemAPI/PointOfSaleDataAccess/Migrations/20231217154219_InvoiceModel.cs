using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PointOfSaleDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InvoiceModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "InvoiceEntityId",
                table: "Stocks",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComapnyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TotalItemCost = table.Column<double>(type: "float", nullable: false),
                    OtherCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5576), new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "InvoiceEntityId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5745), null, new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "InvoiceEntityId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5748), null, new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "InvoiceEntityId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5751), null, new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "InvoiceEntityId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5754), null, new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "InvoiceEntityId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5756), null, new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "InvoiceEntityId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5758), null, new DateTime(2023, 12, 17, 21, 12, 18, 995, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_InvoiceEntityId",
                table: "Stocks",
                column: "InvoiceEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Invoices_InvoiceEntityId",
                table: "Stocks",
                column: "InvoiceEntityId",
                principalTable: "Invoices",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Invoices_InvoiceEntityId",
                table: "Stocks");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_InvoiceEntityId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "InvoiceEntityId",
                table: "Stocks");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6065), new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6091), new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6094), new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6097), new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6099), new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6391), new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6396), new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6399), new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6402), new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6404), new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6406), new DateTime(2023, 12, 17, 9, 15, 21, 217, DateTimeKind.Local).AddTicks(6407) });
        }
    }
}
