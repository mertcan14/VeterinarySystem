using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class GradeAnimalGenus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "grades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "animals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GradeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_animals_grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "genus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AnimalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_genus_animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_animals_GradeId",
                table: "animals",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_genus_AnimalId",
                table: "genus",
                column: "AnimalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "genus");

            migrationBuilder.DropTable(
                name: "animals");

            migrationBuilder.DropTable(
                name: "grades");
        }
    }
}
