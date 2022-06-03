using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Site.Migrations
{
    public partial class modeledit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Port_Eigenaar",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeschrijvingProgrammeer",
                table: "Port_Eigenaar",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Geboortedatum",
                table: "Port_Eigenaar",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Hobby",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true),
                    Port_EigenaarId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobby", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hobby_Port_Eigenaar_Port_EigenaarId",
                        column: x => x.Port_EigenaarId,
                        principalTable: "Port_Eigenaar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hobby_Port_EigenaarId",
                table: "Hobby",
                column: "Port_EigenaarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobby");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Port_Eigenaar");

            migrationBuilder.DropColumn(
                name: "BeschrijvingProgrammeer",
                table: "Port_Eigenaar");

            migrationBuilder.DropColumn(
                name: "Geboortedatum",
                table: "Port_Eigenaar");
        }
    }
}
