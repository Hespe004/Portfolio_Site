using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Site.Migrations
{
    public partial class Port_eigenaar_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Port_Eigenaar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true),
                    Leeftijd = table.Column<int>(type: "INTEGER", nullable: false),
                    MiddelbareSchool = table.Column<string>(type: "TEXT", nullable: true),
                    HogereSchool = table.Column<string>(type: "TEXT", nullable: true),
                    Foto = table.Column<string>(type: "TEXT", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Port_Eigenaar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Programeertaal",
                columns: table => new
                {
                    Naam = table.Column<string>(type: "TEXT", nullable: false),
                    Kennis = table.Column<int>(type: "INTEGER", nullable: false),
                    Port_EigenaarId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programeertaal", x => x.Naam);
                    table.ForeignKey(
                        name: "FK_Programeertaal_Port_Eigenaar_Port_EigenaarId",
                        column: x => x.Port_EigenaarId,
                        principalTable: "Port_Eigenaar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programeertaal_Port_EigenaarId",
                table: "Programeertaal",
                column: "Port_EigenaarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programeertaal");

            migrationBuilder.DropTable(
                name: "Port_Eigenaar");
        }
    }
}
