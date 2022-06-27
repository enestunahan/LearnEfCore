using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnEfCore.Migrations
{
    public partial class AddNewTableAndOneToOneRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 22, 33, 58, 914, DateTimeKind.Local).AddTicks(2392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 27, 10, 56, 46, 448, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.CreateTable(
                name: "BooksDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISSN = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "0000-0000-0000"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false, defaultValue: 2022),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BooksDetail_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BooksDetail",
                columns: new[] { "Id", "BookId", "City", "Country", "Year" },
                values: new object[] { 1, 1, "Turkey", null, 2020 });

            migrationBuilder.CreateIndex(
                name: "IX_BooksDetail_BookId",
                table: "BooksDetail",
                column: "BookId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksDetail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 27, 10, 56, 46, 448, DateTimeKind.Local).AddTicks(3677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 27, 22, 33, 58, 914, DateTimeKind.Local).AddTicks(2392));
        }
    }
}
