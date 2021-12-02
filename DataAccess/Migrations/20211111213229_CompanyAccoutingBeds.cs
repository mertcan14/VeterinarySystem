using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CompanyAccoutingBeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_hospitalizasyonBeds_CompanyId",
                table: "hospitalizasyonBeds",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_accoutings_CompanyId",
                table: "accoutings",
                column: "CompanyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_accoutings_companies_CompanyId",
                table: "accoutings",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hospitalizasyonBeds_companies_CompanyId",
                table: "hospitalizasyonBeds",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accoutings_companies_CompanyId",
                table: "accoutings");

            migrationBuilder.DropForeignKey(
                name: "FK_hospitalizasyonBeds_companies_CompanyId",
                table: "hospitalizasyonBeds");

            migrationBuilder.DropIndex(
                name: "IX_hospitalizasyonBeds_CompanyId",
                table: "hospitalizasyonBeds");

            migrationBuilder.DropIndex(
                name: "IX_accoutings_CompanyId",
                table: "accoutings");
        }
    }
}
