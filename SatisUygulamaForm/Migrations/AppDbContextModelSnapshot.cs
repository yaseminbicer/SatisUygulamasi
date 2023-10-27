﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SatisUygulamaForm.Persistence;

#nullable disable




namespace SatisUygulamaForm.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SatisUygulamaForm.Fis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FisNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusteriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Fis");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Fis");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("SatisUygulamaForm.FisSatir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barkod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BrFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("FisId")
                        .HasColumnType("int");

                    b.Property<decimal>("Miktar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("StokKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FisId");

                    b.ToTable("FisSatir");
                });

            modelBuilder.Entity("SatisUygulamaForm.UrunList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("SatisUygulamaForm.Urun", b =>
                {
                    b.HasBaseType("SatisUygulamaForm.Fis");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("AlisFiyati")
                        .HasColumnType("float");

                    b.Property<string>("Barkod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BrFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GenelToplam")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KdvOrani")
                        .HasColumnType("int");

                    b.Property<decimal>("Miktar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("SatisFiyati")
                        .HasColumnType("float");

                    b.Property<string>("UrunAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunGrubu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunGrup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ÜrünAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Urun");
                });

            modelBuilder.Entity("SatisUygulamaForm.FisSatir", b =>
                {
                    b.HasOne("SatisUygulamaForm.Fis", null)
                        .WithMany("FisSatirlari")
                        .HasForeignKey("FisId");
                });

            modelBuilder.Entity("SatisUygulamaForm.Fis", b =>
                {
                    b.Navigation("FisSatirlari");
                });
#pragma warning restore 612, 618
        }
    }
}