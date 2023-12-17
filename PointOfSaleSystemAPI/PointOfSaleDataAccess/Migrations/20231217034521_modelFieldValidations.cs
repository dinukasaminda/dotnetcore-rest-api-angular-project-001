using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PointOfSaleDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class modelFieldValidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BarcodePrefix",
                table: "Stocks",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BarcodePrefix",
                table: "Products",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BarcodePrefix",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "BarcodePrefix",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9309), new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9317), new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9319), new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9321), new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9323), new DateTime(2023, 12, 16, 10, 3, 40, 932, DateTimeKind.Local).AddTicks(9324) });
        }
    }
}
