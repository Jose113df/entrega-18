﻿// <auto-generated />
using EscolaDotNet.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace escoladotnet.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230328124456_CompetenciaVinteSeis")]
    partial class CompetenciaVinteSeis
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EscolaDotNet.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int")
                        .HasColumnName("ch");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("conteudo");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("perfil");

                    b.Property<int>("PrazoMeses")
                        .HasColumnType("int")
                        .HasColumnName("Prazo");

                    b.Property<string>("PreRequisitos")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("requisito");

                    b.Property<string>("Recursos")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("recursos");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.ToTable("Curso", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
