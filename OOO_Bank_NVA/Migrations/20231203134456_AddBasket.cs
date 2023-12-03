using Microsoft.EntityFrameworkCore.Migrations;

namespace OOO_Bank_NVA.Migrations
{
    public partial class AddBasket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Tovars");

            migrationBuilder.AddColumn<int>(
                name: "MaxCount",
                table: "Tovars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Baskets",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxCount",
                table: "Tovars");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Baskets");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Tovars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
