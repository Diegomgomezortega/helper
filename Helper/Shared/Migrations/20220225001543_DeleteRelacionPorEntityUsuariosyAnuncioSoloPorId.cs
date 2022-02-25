using Microsoft.EntityFrameworkCore.Migrations;

namespace Helper.Shared.Migrations
{
    public partial class DeleteRelacionPorEntityUsuariosyAnuncioSoloPorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anuncios_Usuarios_UsuarioId",
                table: "Anuncios");

            migrationBuilder.DropIndex(
                name: "IX_Anuncios_UsuarioId",
                table: "Anuncios");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Anuncios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Anuncios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Anuncios_UsuarioId",
                table: "Anuncios",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anuncios_Usuarios_UsuarioId",
                table: "Anuncios",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
