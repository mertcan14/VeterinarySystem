using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class PetAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    GenusId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pets_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pets_genus_GenusId",
                        column: x => x.GenusId,
                        principalTable: "genus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pets_CustomerId",
                table: "pets",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_pets_GenusId",
                table: "pets",
                column: "GenusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pets");
        }
    }
}
