using Microsoft.EntityFrameworkCore.Migrations;

namespace OOO_Bank_NVA.Migrations
{
    public partial class AddTovars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Tovar_TovarId",
                table: "Baskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tovar",
                table: "Tovar");

            migrationBuilder.RenameTable(
                name: "Tovar",
                newName: "Tovars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tovars",
                table: "Tovars",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Tovars_TovarId",
                table: "Baskets",
                column: "TovarId",
                principalTable: "Tovars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Tovars_TovarId",
                table: "Baskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tovars",
                table: "Tovars");

            migrationBuilder.RenameTable(
                name: "Tovars",
                newName: "Tovar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tovar",
                table: "Tovar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Tovar_TovarId",
                table: "Baskets",
                column: "TovarId",
                principalTable: "Tovar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
