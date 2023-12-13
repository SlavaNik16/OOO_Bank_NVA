using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace OOO_Bank_NVA.Migrations
{
    public partial class EditStringDataEnd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateEnd",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "Cards",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
