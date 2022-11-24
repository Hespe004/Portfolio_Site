using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Site.Migrations
{
    public partial class UpdateHobby2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    port_EigenaarId = table.Column<int>(type: "INTEGER", nullable: true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hobbys_Port_Eigenaar_port_EigenaarId",
                        column: x => x.port_EigenaarId,
                        principalTable: "Port_Eigenaar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hobbys_port_EigenaarId",
                table: "Hobbys",
                column: "port_EigenaarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbys");
        }
    }
}
