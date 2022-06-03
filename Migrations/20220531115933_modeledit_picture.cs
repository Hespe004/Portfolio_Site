using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Site.Migrations
{
    public partial class modeledit_picture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Port_Eigenaar");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Port_Eigenaar");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "Port_Eigenaar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Port_Eigenaar");

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Port_Eigenaar",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Port_Eigenaar",
                type: "nvarchar(100)",
                nullable: true);
        }
    }
}
