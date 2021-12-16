using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class animalchangeforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_animals_grades_GradeId",
                table: "animals");

            migrationBuilder.DropForeignKey(
                name: "FK_genus_animals_AnimalId",
                table: "genus");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "genus",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GradeId",
                table: "animals",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_animals_grades_GradeId",
                table: "animals",
                column: "GradeId",
                principalTable: "grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_genus_animals_AnimalId",
                table: "genus",
                column: "AnimalId",
                principalTable: "animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_animals_grades_GradeId",
                table: "animals");

            migrationBuilder.DropForeignKey(
                name: "FK_genus_animals_AnimalId",
                table: "genus");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "genus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "GradeId",
                table: "animals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_animals_grades_GradeId",
                table: "animals",
                column: "GradeId",
                principalTable: "grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_genus_animals_AnimalId",
                table: "genus",
                column: "AnimalId",
                principalTable: "animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
