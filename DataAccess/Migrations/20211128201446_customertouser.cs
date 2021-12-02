using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class customertouser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_customers_UserId",
                table: "customers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_users_UserId",
                table: "customers",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_users_UserId",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_UserId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "customers");
        }
    }
}
