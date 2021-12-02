using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class usercustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "addresses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_addresses_UserId",
                table: "addresses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_users_UserId",
                table: "addresses",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_users_UserId",
                table: "addresses");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropIndex(
                name: "IX_addresses_UserId",
                table: "addresses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "addresses");
        }
    }
}
