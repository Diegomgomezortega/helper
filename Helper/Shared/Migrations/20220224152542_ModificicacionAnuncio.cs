using Microsoft.EntityFrameworkCore.Migrations;

namespace Helper.Shared.Migrations
{
    public partial class ModificicacionAnuncio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Especie",
                table: "Anuncios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ColorRGB1",
                table: "Anuncios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ColorRGB2",
                table: "Anuncios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorRGB1",
                table: "Anuncios");

            migrationBuilder.DropColumn(
                name: "ColorRGB2",
                table: "Anuncios");

            migrationBuilder.AlterColumn<string>(
                name: "Especie",
                table: "Anuncios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
