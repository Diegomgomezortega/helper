using Microsoft.EntityFrameworkCore.Migrations;

namespace Helper.Shared.Migrations
{
    public partial class ModificicacionTablaAnuncioyRelacionConUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Anuncios_Id_Usuario",
                table: "Anuncios");

            migrationBuilder.DropColumn(
                name: "Id_Usuario",
                table: "Anuncios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Id_Usuario",
                table: "Anuncios",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Anuncios_Id_Usuario",
                table: "Anuncios",
                column: "Id_Usuario");
        }
    }
}
