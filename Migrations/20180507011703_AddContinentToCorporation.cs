using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Dropdowns.Migrations
{
    public partial class AddContinentToCorporation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corporation_Country_CountryID",
                table: "Corporation");

            migrationBuilder.AlterColumn<int>(
                name: "CountryID",
                table: "Corporation",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContinentID",
                table: "Corporation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Corporation_ContinentID",
                table: "Corporation",
                column: "ContinentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Corporation_Continent_ContinentID",
                table: "Corporation",
                column: "ContinentID",
                principalTable: "Continent",
                principalColumn: "ContinentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Corporation_Country_CountryID",
                table: "Corporation",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corporation_Continent_ContinentID",
                table: "Corporation");

            migrationBuilder.DropForeignKey(
                name: "FK_Corporation_Country_CountryID",
                table: "Corporation");

            migrationBuilder.DropIndex(
                name: "IX_Corporation_ContinentID",
                table: "Corporation");

            migrationBuilder.DropColumn(
                name: "ContinentID",
                table: "Corporation");

            migrationBuilder.AlterColumn<int>(
                name: "CountryID",
                table: "Corporation",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Corporation_Country_CountryID",
                table: "Corporation",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
