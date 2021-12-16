using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addresschangeforeign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_districts_DistrictId",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_districts_cities_CityId",
                table: "districts");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "districts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "addresses",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_districts_DistrictId",
                table: "addresses",
                column: "DistrictId",
                principalTable: "districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_districts_cities_CityId",
                table: "districts",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_districts_DistrictId",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_districts_cities_CityId",
                table: "districts");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "districts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "addresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_districts_DistrictId",
                table: "addresses",
                column: "DistrictId",
                principalTable: "districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_districts_cities_CityId",
                table: "districts",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
