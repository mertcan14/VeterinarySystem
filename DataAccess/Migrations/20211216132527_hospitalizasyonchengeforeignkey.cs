using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class hospitalizasyonchengeforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "hospitalizasyons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_hospitalizasyons_PetId",
                table: "hospitalizasyons",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_hospitalizasyons_pets_PetId",
                table: "hospitalizasyons",
                column: "PetId",
                principalTable: "pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hospitalizasyons_pets_PetId",
                table: "hospitalizasyons");

            migrationBuilder.DropIndex(
                name: "IX_hospitalizasyons_PetId",
                table: "hospitalizasyons");

            migrationBuilder.DropColumn(
                name: "PetId",
                table: "hospitalizasyons");
        }
    }
}
