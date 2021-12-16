using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class hospitalizasyonchangeforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hospitalizasyonBeds_companies_CompanyId",
                table: "hospitalizasyonBeds");

            migrationBuilder.DropForeignKey(
                name: "FK_hospitalizasyonBeds_hospitalCategories_HospitalCategoryId",
                table: "hospitalizasyonBeds");

            migrationBuilder.DropForeignKey(
                name: "FK_hospitalizasyons_hospitalizasyonBeds_HospitalizasyonBedId",
                table: "hospitalizasyons");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalizasyonBedId",
                table: "hospitalizasyons",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HospitalCategoryId",
                table: "hospitalizasyonBeds",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "hospitalizasyonBeds",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_hospitalizasyonBeds_companies_CompanyId",
                table: "hospitalizasyonBeds",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hospitalizasyonBeds_hospitalCategories_HospitalCategoryId",
                table: "hospitalizasyonBeds",
                column: "HospitalCategoryId",
                principalTable: "hospitalCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hospitalizasyons_hospitalizasyonBeds_HospitalizasyonBedId",
                table: "hospitalizasyons",
                column: "HospitalizasyonBedId",
                principalTable: "hospitalizasyonBeds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hospitalizasyonBeds_companies_CompanyId",
                table: "hospitalizasyonBeds");

            migrationBuilder.DropForeignKey(
                name: "FK_hospitalizasyonBeds_hospitalCategories_HospitalCategoryId",
                table: "hospitalizasyonBeds");

            migrationBuilder.DropForeignKey(
                name: "FK_hospitalizasyons_hospitalizasyonBeds_HospitalizasyonBedId",
                table: "hospitalizasyons");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalizasyonBedId",
                table: "hospitalizasyons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "HospitalCategoryId",
                table: "hospitalizasyonBeds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "hospitalizasyonBeds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_hospitalizasyonBeds_companies_CompanyId",
                table: "hospitalizasyonBeds",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_hospitalizasyonBeds_hospitalCategories_HospitalCategoryId",
                table: "hospitalizasyonBeds",
                column: "HospitalCategoryId",
                principalTable: "hospitalCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_hospitalizasyons_hospitalizasyonBeds_HospitalizasyonBedId",
                table: "hospitalizasyons",
                column: "HospitalizasyonBedId",
                principalTable: "hospitalizasyonBeds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
