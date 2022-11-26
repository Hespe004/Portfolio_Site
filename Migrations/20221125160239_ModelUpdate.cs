using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Site.Migrations
{
    public partial class ModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MiddelbareSchool",
                table: "Port_Eigenaar",
                newName: "PostCode");

            migrationBuilder.RenameColumn(
                name: "HogereSchool",
                table: "Port_Eigenaar",
                newName: "Plaats");

            migrationBuilder.AddColumn<string>(
                name: "LinkedIn",
                table: "Port_Eigenaar",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationaliteit",
                table: "Port_Eigenaar",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HogereSchools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    port_EigenaarId = table.Column<int>(type: "INTEGER", nullable: true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true),
                    Opleiding = table.Column<string>(type: "TEXT", nullable: true),
                    Begin_Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eind_Datum = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HogereSchools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HogereSchools_Port_Eigenaar_port_EigenaarId",
                        column: x => x.port_EigenaarId,
                        principalTable: "Port_Eigenaar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MiddelbareSchools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    port_EigenaarId = table.Column<int>(type: "INTEGER", nullable: true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true),
                    Opleiding = table.Column<string>(type: "TEXT", nullable: true),
                    Begin_Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eind_Datum = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiddelbareSchools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MiddelbareSchools_Port_Eigenaar_port_EigenaarId",
                        column: x => x.port_EigenaarId,
                        principalTable: "Port_Eigenaar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HogereSchools_port_EigenaarId",
                table: "HogereSchools",
                column: "port_EigenaarId");

            migrationBuilder.CreateIndex(
                name: "IX_MiddelbareSchools_port_EigenaarId",
                table: "MiddelbareSchools",
                column: "port_EigenaarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HogereSchools");

            migrationBuilder.DropTable(
                name: "MiddelbareSchools");

            migrationBuilder.DropColumn(
                name: "LinkedIn",
                table: "Port_Eigenaar");

            migrationBuilder.DropColumn(
                name: "Nationaliteit",
                table: "Port_Eigenaar");

            migrationBuilder.RenameColumn(
                name: "PostCode",
                table: "Port_Eigenaar",
                newName: "MiddelbareSchool");

            migrationBuilder.RenameColumn(
                name: "Plaats",
                table: "Port_Eigenaar",
                newName: "HogereSchool");
        }
    }
}
