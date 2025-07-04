﻿
using ExploradorFaunaMarinaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExploradorFaunaMarinaAPI.Migrations
{
    [DbContext(typeof(MarinaContext))]
    partial class MarinaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.6");

            modelBuilder.Entity("ExploradorFaunaMarinaAPI.Models.EspecieMarina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Habitat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCientifico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreComun")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EspeciesMarinas");
                });

            modelBuilder.Entity("ExploradorFaunaMarinaAPI.Models.TipSnorkeling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TipsSnorkeling");
                });
#pragma warning restore 612, 618
        }
    }
}
