using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class usedproductadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Transactions_TransactionsId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_TransactionsId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "TransactionsId",
                table: "products");

            migrationBuilder.CreateTable(
                name: "usedProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<int>(nullable: true),
                    TransactionsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usedProducts_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usedProducts_Transactions_TransactionsId",
                        column: x => x.TransactionsId,
                        principalTable: "Transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_usedProducts_ProductId",
                table: "usedProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_usedProducts_TransactionsId",
                table: "usedProducts",
                column: "TransactionsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "usedProducts");

            migrationBuilder.AddColumn<int>(
                name: "TransactionsId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_TransactionsId",
                table: "products",
                column: "TransactionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Transactions_TransactionsId",
                table: "products",
                column: "TransactionsId",
                principalTable: "Transactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
