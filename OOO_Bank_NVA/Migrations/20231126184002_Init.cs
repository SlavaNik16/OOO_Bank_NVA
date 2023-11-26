using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    StatusType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBBanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tovar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: true),
                    Tittle = table.Column<string>(maxLength: 120, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tovar", x => x.Id);
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
                    CardId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    PersonId = table.Column<Guid>(nullable: false)
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
                        name: "FK_Baskets_Tovar_TovarId",
                        column: x => x.TovarId,
                        principalTable: "Tovar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 200, nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: true),
                    PersonId = table.Column<Guid>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    OperationType = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operations_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
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
                name: "IX_DBBank_StatusType",
                table: "DBBanks",
                column: "StatusType",
                filter: "DeletedAt is null");

            migrationBuilder.CreateIndex(
                name: "IX_Operation_OperationType",
                table: "Operations",
                column: "OperationType",
                filter: "DeletedAt is null");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_PersonId",
                table: "Operations",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CardId",
                table: "Persons",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Phone",
                table: "Persons",
                column: "Phone",
                unique: true,
                filter: "DeletedAt is null");

            migrationBuilder.CreateIndex(
                name: "IX_Tovar_Tittle",
                table: "Tovar",
                column: "Tittle",
                unique: true,
                filter: "DeletedAt is null");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "DBBanks");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Tovar");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
