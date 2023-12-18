using Microsoft.EntityFrameworkCore.Migrations;

namespace OOO_Bank_NVA.Migrations
{
    public partial class AddRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DBBank_StatusType",
                table: "DBBanks");

            migrationBuilder.DropColumn(
                name: "StatusType",
                table: "DBBanks");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "DBBanks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "DBBanks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DBBank_Status",
                table: "DBBanks",
                column: "Status",
                filter: "DeletedAt is null");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DBBank_Status",
                table: "DBBanks");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "DBBanks");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "DBBanks");

            migrationBuilder.AddColumn<int>(
                name: "StatusType",
                table: "DBBanks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DBBank_StatusType",
                table: "DBBanks",
                column: "StatusType",
                filter: "DeletedAt is null");
        }
    }
}
