using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Site.Migrations
{
    public partial class _2311221 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gesloten",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "VerwijderDatum",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "WordtVerwijderd",
                table: "Projects");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Gesloten",
                table: "Projects",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "VerwijderDatum",
                table: "Projects",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "WordtVerwijderd",
                table: "Projects",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
