using Microsoft.EntityFrameworkCore.Migrations;

namespace OOO_Bank_NVA.Migrations
{
    public partial class UpdateTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tovar_Tittle",
                table: "Tovars");

            migrationBuilder.DropColumn(
                name: "Tittle",
                table: "Tovars");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Tovars",
                maxLength: 120,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Tovar_Title",
                table: "Tovars",
                column: "Title",
                unique: true,
                filter: "DeletedAt is null");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tovar_Title",
                table: "Tovars");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Tovars");

            migrationBuilder.AddColumn<string>(
                name: "Tittle",
                table: "Tovars",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Tovar_Tittle",
                table: "Tovars",
                column: "Tittle",
                unique: true,
                filter: "DeletedAt is null");
        }
    }
}
