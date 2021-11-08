using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Hospitalizasyon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hospitalCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hospitalCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hospitalizasyonBeds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    HospitalCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hospitalizasyonBeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hospitalizasyonBeds_hospitalCategories_HospitalCategoryId",
                        column: x => x.HospitalCategoryId,
                        principalTable: "hospitalCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "hospitalizasyons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: true),
                    HospitalizasyonBedId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hospitalizasyons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hospitalizasyons_hospitalizasyonBeds_HospitalizasyonBedId",
                        column: x => x.HospitalizasyonBedId,
                        principalTable: "hospitalizasyonBeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hospitalizasyonBeds_HospitalCategoryId",
                table: "hospitalizasyonBeds",
                column: "HospitalCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_hospitalizasyons_HospitalizasyonBedId",
                table: "hospitalizasyons",
                column: "HospitalizasyonBedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hospitalizasyons");

            migrationBuilder.DropTable(
                name: "hospitalizasyonBeds");

            migrationBuilder.DropTable(
                name: "hospitalCategories");
        }
    }
}
