using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class appointmentpet2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_appointments_PetId",
                table: "appointments",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_pets_PetId",
                table: "appointments",
                column: "PetId",
                principalTable: "pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_pets_PetId",
                table: "appointments");

            migrationBuilder.DropIndex(
                name: "IX_appointments_PetId",
                table: "appointments");

            migrationBuilder.DropColumn(
                name: "PetId",
                table: "appointments");
        }
    }
}
