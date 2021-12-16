using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class petchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pets_customers_CustomerId",
                table: "pets");

            migrationBuilder.DropForeignKey(
                name: "FK_pets_genders_GenderId",
                table: "pets");

            migrationBuilder.DropForeignKey(
                name: "FK_pets_genus_GenusId",
                table: "pets");

            migrationBuilder.AlterColumn<int>(
                name: "GenusId",
                table: "pets",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "pets",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "pets",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_pets_customers_CustomerId",
                table: "pets",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pets_genders_GenderId",
                table: "pets",
                column: "GenderId",
                principalTable: "genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pets_genus_GenusId",
                table: "pets",
                column: "GenusId",
                principalTable: "genus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pets_customers_CustomerId",
                table: "pets");

            migrationBuilder.DropForeignKey(
                name: "FK_pets_genders_GenderId",
                table: "pets");

            migrationBuilder.DropForeignKey(
                name: "FK_pets_genus_GenusId",
                table: "pets");

            migrationBuilder.AlterColumn<int>(
                name: "GenusId",
                table: "pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_pets_customers_CustomerId",
                table: "pets",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_pets_genders_GenderId",
                table: "pets",
                column: "GenderId",
                principalTable: "genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_pets_genus_GenusId",
                table: "pets",
                column: "GenusId",
                principalTable: "genus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
