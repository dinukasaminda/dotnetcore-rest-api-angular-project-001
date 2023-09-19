using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DemoRestApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorsToTodos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Dinuka Bandara" },
                    { 2, "Isanka" },
                    { 3, "Dilshan" },
                    { 4, "M Rajapaksha" }
                });

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2023, 9, 19, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290), "Go to suppermarket and get some vegitables", new DateTime(2023, 9, 20, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290), 0, "Need some vegitables" });

            migrationBuilder.InsertData(
                table: "todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 19, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9250), "sample 2", new DateTime(2023, 9, 21, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9280), 1, "Collect letters" },
                    { 3, 2, new DateTime(2023, 9, 19, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290), "Weekly Gym", new DateTime(2023, 9, 22, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290), 0, "Go to GYM" },
                    { 4, 3, new DateTime(2023, 9, 19, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290), "Profile photo update", new DateTime(2023, 9, 24, 6, 43, 30, 264, DateTimeKind.Local).AddTicks(9290), 1, "Upwork Profile update" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_todos_AuthorId",
                table: "todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_todos_Authors_AuthorId",
                table: "todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_todos_Authors_AuthorId",
                table: "todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_todos_AuthorId",
                table: "todos");

            migrationBuilder.DeleteData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "todos");

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { new DateTime(2023, 9, 18, 21, 26, 6, 940, DateTimeKind.Local).AddTicks(8710), "sample 2", new DateTime(2023, 9, 20, 21, 26, 6, 940, DateTimeKind.Local).AddTicks(8740), 1, "Collect letters" });
        }
    }
}
