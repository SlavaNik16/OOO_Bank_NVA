using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OOO_Bank_NVA.Migrations
{
    public partial class ChangeBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Cards_CardId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_CardId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "CardName",
                table: "Persons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardName",
                table: "Persons");

            migrationBuilder.AddColumn<Guid>(
                name: "CardId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CardId",
                table: "Persons",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Cards_CardId",
                table: "Persons",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
