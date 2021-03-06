// <auto-generated />
using System;
using Helper.Shared.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Helper.Shared.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20220224144456_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Helper.Shared.Data.Entidades.Anuncio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Especie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAnuncio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSuceso")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoRuta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id_Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tamano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Anuncios");
                });
#pragma warning restore 612, 618
        }
    }
}
