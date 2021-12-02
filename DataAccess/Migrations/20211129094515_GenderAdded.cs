using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class GenderAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "pets");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "pets");

            migrationBuilder.DropColumn(
                name: "IdentificationNumber",
                table: "pets");

            migrationBuilder.AddColumn<int>(
                name: "BirthYear",
                table: "pets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "pets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "pets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MicrochipNumber",
                table: "pets",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pets_GenderId",
                table: "pets",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_pets_genders_GenderId",
                table: "pets",
                column: "GenderId",
                principalTable: "genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pets_genders_GenderId",
                table: "pets");

            migrationBuilder.DropTable(
                name: "genders");

            migrationBuilder.DropIndex(
                name: "IX_pets_GenderId",
                table: "pets");

            migrationBuilder.DropColumn(
                name: "BirthYear",
                table: "pets");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "pets");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "pets");

            migrationBuilder.DropColumn(
                name: "MicrochipNumber",
                table: "pets");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "pets",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentificationNumber",
                table: "pets",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
