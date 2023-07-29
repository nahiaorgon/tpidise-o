﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reciplas.Clases;

#nullable disable

namespace Reciplas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Reciplas.Clases.Compras", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("proveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Reciplas.Clases.LineaCompra", b =>
                {
                    b.Property<int>("Comprasid")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("id_compra")
                        .HasColumnType("int");

                    b.Property<int>("id_producto")
                        .HasColumnType("int");

                    b.Property<int>("linea")
                        .HasColumnType("int");

                    b.Property<decimal>("precio_unitario")
                        .HasColumnType("decimal(12, 2)");

                    b.HasIndex("Comprasid");

                    b.ToTable("LineaCompras");
                });

            modelBuilder.Entity("Reciplas.Clases.LineaVenta", b =>
                {
                    b.Property<int>("Ventasid")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("id_producto")
                        .HasColumnType("int");

                    b.Property<int>("id_venta")
                        .HasColumnType("int");

                    b.Property<int>("linea")
                        .HasColumnType("int");

                    b.Property<decimal>("precio_unitario")
                        .HasColumnType("decimal(12, 2)");

                    b.HasIndex("Ventasid");

                    b.ToTable("LineaVentas");
                });

            modelBuilder.Entity("Reciplas.Clases.Productos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_actualizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(12, 2)");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Reciplas.Clases.Ventas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Reciplas.Clases.LineaCompra", b =>
                {
                    b.HasOne("Reciplas.Clases.Compras", "Compras")
                        .WithMany()
                        .HasForeignKey("Comprasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compras");
                });

            modelBuilder.Entity("Reciplas.Clases.LineaVenta", b =>
                {
                    b.HasOne("Reciplas.Clases.Ventas", "Ventas")
                        .WithMany()
                        .HasForeignKey("Ventasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
