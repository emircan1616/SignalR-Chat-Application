﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SinemaOtomasyonu;

#nullable disable

namespace SignalR5.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220906133657_100")]
    partial class _100
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SignalR5.Models.Mesaj", b =>
                {
                    b.Property<int>("MesajId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MesajId"), 1L, 1);

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Metin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MesajId");

                    b.ToTable("Mesajlar");
                });
#pragma warning restore 612, 618
        }
    }
}
