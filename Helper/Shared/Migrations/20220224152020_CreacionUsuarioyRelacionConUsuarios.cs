using Microsoft.EntityFrameworkCore.Migrations;

namespace Helper.Shared.Migrations
{
    public partial class CreacionUsuarioyRelacionConUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Anuncios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anuncios_Usuarios_UsuarioId",
                table: "Anuncios");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Anuncios_UsuarioId",
                table: "Anuncios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Anuncios");
        }
    }
}
