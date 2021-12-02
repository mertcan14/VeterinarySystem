using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class productrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "categories",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
