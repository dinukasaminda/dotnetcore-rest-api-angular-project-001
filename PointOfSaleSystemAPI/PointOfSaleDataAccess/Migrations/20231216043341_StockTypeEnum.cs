using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PointOfSaleDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class StockTypeEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9148), new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9162), new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9165), new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9166), new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9168), new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Type", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9309), 0, new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Type", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9314), 0, new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Type", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9317), 0, new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Type", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9319), 0, new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Type", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9321), 0, new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Type", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9323), 0, new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9324) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Stocks");

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

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2241), new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2245), new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2247), new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2251), new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2253), new DateTime(2023, 12, 16, 9, 12, 13, 132, DateTimeKind.Local).AddTicks(2254) });
        }
    }
}
