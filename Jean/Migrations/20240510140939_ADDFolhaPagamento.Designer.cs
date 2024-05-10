﻿// <auto-generated />
using System;
using Jean.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jean.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20240510140939_ADDFolhaPagamento")]
    partial class ADDFolhaPagamento
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Jean.Modelos.FolhaPagamento", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<double>("Ano")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<double>("Mes")
                        .HasColumnType("REAL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("QuantTrabalhadas")
                        .HasColumnType("REAL");

                    b.Property<double>("ValorHoras")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("FolhaPagamentos");
                });

            modelBuilder.Entity("Jean.Modelos.Funcionario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<double>("Cpf")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
