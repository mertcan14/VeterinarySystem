using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class transactionschangeforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_pets_PetId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_usedProducts_products_ProductId",
                table: "usedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_usedProducts_Transactions_TransactionsId",
                table: "usedProducts");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionsId",
                table: "usedProducts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "usedProducts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PetId",
                table: "Transactions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_pets_PetId",
                table: "Transactions",
                column: "PetId",
                principalTable: "pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usedProducts_products_ProductId",
                table: "usedProducts",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usedProducts_Transactions_TransactionsId",
                table: "usedProducts",
                column: "TransactionsId",
                principalTable: "Transactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_pets_PetId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_usedProducts_products_ProductId",
                table: "usedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_usedProducts_Transactions_TransactionsId",
                table: "usedProducts");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionsId",
                table: "usedProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "usedProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PetId",
                table: "Transactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_pets_PetId",
                table: "Transactions",
                column: "PetId",
                principalTable: "pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_usedProducts_products_ProductId",
                table: "usedProducts",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_usedProducts_Transactions_TransactionsId",
                table: "usedProducts",
                column: "TransactionsId",
                principalTable: "Transactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
