using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Site.Migrations
{
    public partial class modeledit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programeertaal_Port_Eigenaar_Port_EigenaarId",
                table: "Programeertaal");

            migrationBuilder.RenameColumn(
                name: "Port_EigenaarId",
                table: "Programeertaal",
                newName: "port_EigenaarId");

            migrationBuilder.RenameIndex(
                name: "IX_Programeertaal_Port_EigenaarId",
                table: "Programeertaal",
                newName: "IX_Programeertaal_port_EigenaarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programeertaal_Port_Eigenaar_port_EigenaarId",
                table: "Programeertaal",
                column: "port_EigenaarId",
                principalTable: "Port_Eigenaar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programeertaal_Port_Eigenaar_port_EigenaarId",
                table: "Programeertaal");

            migrationBuilder.RenameColumn(
                name: "port_EigenaarId",
                table: "Programeertaal",
                newName: "Port_EigenaarId");

            migrationBuilder.RenameIndex(
                name: "IX_Programeertaal_port_EigenaarId",
                table: "Programeertaal",
                newName: "IX_Programeertaal_Port_EigenaarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programeertaal_Port_Eigenaar_Port_EigenaarId",
                table: "Programeertaal",
                column: "Port_EigenaarId",
                principalTable: "Port_Eigenaar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
