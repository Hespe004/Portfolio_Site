using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Site.Migrations
{
    public partial class modeledit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Programeertaal",
                table: "Programeertaal");

            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                table: "Programeertaal",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Programeertaal",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Programeertaal",
                table: "Programeertaal",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Programeertaal",
                table: "Programeertaal");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Programeertaal");

            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                table: "Programeertaal",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Programeertaal",
                table: "Programeertaal",
                column: "Naam");
        }
    }
}
