﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleMvcApp.Data;

#nullable disable

namespace SampleMvcApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240711043512_migracion2024")]
    partial class migracion2024
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SampleMvcApp.ViewModels.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SampleMvcApp.ViewModels.Conductor", b =>
                {
                    b.Property<int>("IdConductor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdConductor"), 1L, 1);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("FechaEmisionLicencia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimientoLicencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IdConductor");

                    b.ToTable("Conductor");
                });

            modelBuilder.Entity("SampleMvcApp.ViewModels.Reserva", b =>
                {
                    b.Property<int>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReserva"), 1L, 1);

                    b.Property<int?>("CantPersonas")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPartida")
                        .HasColumnType("datetime2");

                    b.Property<string>("PuntoPartida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdReserva");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("SampleMvcApp.ViewModels.Ruta", b =>
                {
                    b.Property<int>("IdRuta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRuta"), 1L, 1);

                    b.Property<DateTime>("FechaEmisionLicencia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimientoLicencia")
                        .HasColumnType("datetime2");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("PuntoLlegada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRuta");

                    b.ToTable("Ruta");
                });

            modelBuilder.Entity("SampleMvcApp.ViewModels.Transporte", b =>
                {
                    b.Property<int>("IdTransporte")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTransporte"), 1L, 1);

                    b.Property<int?>("Capacidad")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTransporte");

                    b.ToTable("Transporte");
                });

            modelBuilder.Entity("SampleMvcApp.ViewModels.Viaje", b =>
                {
                    b.Property<int>("IdViaje")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdViaje"), 1L, 1);

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdViaje");

                    b.ToTable("Viaje");
                });
#pragma warning restore 612, 618
        }
    }
}
