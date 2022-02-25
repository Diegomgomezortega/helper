using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Helper.Shared.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anuncios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Tamano = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaSuceso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAnuncio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FotoRuta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anuncios");
        }
    }
}
