using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class productrelationship2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_products_ProductId",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_ProductId",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CategoryId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "products");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_categories_ProductId",
                table: "categories",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_products_ProductId",
                table: "categories",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
