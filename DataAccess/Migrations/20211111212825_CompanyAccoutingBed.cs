using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CompanyAccoutingBed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "hospitalizasyonBeds",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "accoutings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "hospitalizasyonBeds");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "accoutings");
        }
    }
}
