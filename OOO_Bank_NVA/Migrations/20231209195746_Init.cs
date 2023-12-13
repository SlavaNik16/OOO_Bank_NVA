using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace OOO_Bank_NVA.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: true),
                    Nomer = table.Column<string>(maxLength: 30, nullable: false),
                    CSCCode = table.Column<int>(maxLength: 6, nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    PinCode = table.Column<string>(maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DBBanks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: true),
                    Login = table.Column<string>(maxLength: 80, nullable: false),
                    Password = table.Column<string>(maxLength: 300, nullable: false),
                    Role = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBBanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: true),
                    Surname = table.Column<string>(maxLength: 80, nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    CardName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tovars",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: true),
                    Title = table.Column<string>(maxLength: 120, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    MaxCount = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tovars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: true),
                    TovarId = table.Column<Guid>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    PersonId = table.Column<Guid>(nullable: false),
                    StatusBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Baskets_Tovars_TovarId",
                        column: x => x.TovarId,
                        principalTable: "Tovars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_PersonId",
                table: "Baskets",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_TovarId",
                table: "Baskets",
                column: "TovarId");

            migrationBuilder.CreateIndex(
                name: "IX_Card_Nomer",
                table: "Cards",
                column: "Nomer",
                unique: true,
                filter: "DeletedAt is null");

            migrationBuilder.CreateIndex(
                name: "IX_DBBank_Login",
                table: "DBBanks",
                column: "Login",
                unique: true,
                filter: "DeletedAt is null");

            migrationBuilder.CreateIndex(
                name: "IX_DBBank_Status",
                table: "DBBanks",
                column: "Status",
                filter: "DeletedAt is null");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Phone",
                table: "Persons",
                column: "Phone",
                unique: true,
                filter: "DeletedAt is null");

            migrationBuilder.CreateIndex(
                name: "IX_Tovar_Title",
                table: "Tovars",
                column: "Title",
                unique: true,
                filter: "DeletedAt is null");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "DBBanks");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Tovars");
        }
    }
}
