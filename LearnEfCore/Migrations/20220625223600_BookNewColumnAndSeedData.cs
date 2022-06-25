using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnEfCore.Migrations
{
    public partial class BookNewColumnAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 26, 1, 35, 59, 794, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Tutanamayanlar" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2, "Çalıkuşu" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title" },
                values: new object[] { 3, "Kürk Mantolu Madonna" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }
    }
}
