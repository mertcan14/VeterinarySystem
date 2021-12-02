using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class transactionsadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionsId",
                table: "products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "pets",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    PetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_pets_PetId",
                        column: x => x.PetId,
                        principalTable: "pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_TransactionsId",
                table: "products",
                column: "TransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_pets_PetId",
                table: "pets",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PetId",
                table: "Transactions",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_pets_pets_PetId",
                table: "pets",
                column: "PetId",
                principalTable: "pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_Transactions_TransactionsId",
                table: "products",
                column: "TransactionsId",
                principalTable: "Transactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pets_pets_PetId",
                table: "pets");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Transactions_TransactionsId",
                table: "products");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_products_TransactionsId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_pets_PetId",
                table: "pets");

            migrationBuilder.DropColumn(
                name: "TransactionsId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "PetId",
                table: "pets");
        }
    }
}
