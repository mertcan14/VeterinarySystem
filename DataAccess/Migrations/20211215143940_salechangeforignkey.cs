using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class salechangeforignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_saledProducts_products_ProductId",
                table: "saledProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_saledProducts_sales_SaleId",
                table: "saledProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_sales_pets_PetId",
                table: "sales");

            migrationBuilder.AlterColumn<int>(
                name: "PetId",
                table: "sales",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SaleId",
                table: "saledProducts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "saledProducts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_saledProducts_products_ProductId",
                table: "saledProducts",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_saledProducts_sales_SaleId",
                table: "saledProducts",
                column: "SaleId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sales_pets_PetId",
                table: "sales",
                column: "PetId",
                principalTable: "pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_saledProducts_products_ProductId",
                table: "saledProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_saledProducts_sales_SaleId",
                table: "saledProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_sales_pets_PetId",
                table: "sales");

            migrationBuilder.AlterColumn<int>(
                name: "PetId",
                table: "sales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SaleId",
                table: "saledProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "saledProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_saledProducts_products_ProductId",
                table: "saledProducts",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_saledProducts_sales_SaleId",
                table: "saledProducts",
                column: "SaleId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sales_pets_PetId",
                table: "sales",
                column: "PetId",
                principalTable: "pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
