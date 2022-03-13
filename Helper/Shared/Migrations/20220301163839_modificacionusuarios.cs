using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Helper.Shared.Migrations
{
    public partial class modificacionusuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FotoRuta",
                table: "Anuncios",
                newName: "RutaFoto");

            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "Anuncios",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Anuncios");

            migrationBuilder.RenameColumn(
                name: "RutaFoto",
                table: "Anuncios",
                newName: "FotoRuta");
        }
    }
}
