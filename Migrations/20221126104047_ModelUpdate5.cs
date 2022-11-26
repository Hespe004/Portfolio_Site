using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Site.Migrations
{
    public partial class ModelUpdate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Port_Eigenaar",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Telefoon",
                table: "Port_Eigenaar",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Port_Eigenaar");

            migrationBuilder.DropColumn(
                name: "Telefoon",
                table: "Port_Eigenaar");
        }
    }
}
