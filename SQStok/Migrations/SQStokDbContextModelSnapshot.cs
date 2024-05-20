﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQStok.Model.Context;

#nullable disable

namespace SQStok.Migrations
{
    [DbContext(typeof(SQStokDbContext))]
    partial class SQStokDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SQStok.Model.Context.Birim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Birims");
                });

            modelBuilder.Entity("SQStok.Model.Context.BirimPozisyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BirimID")
                        .HasColumnType("int");

                    b.Property<int>("PozisyonID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BirimID");

                    b.HasIndex("PozisyonID");

                    b.ToTable("BirimPozisyons");
                });

            modelBuilder.Entity("SQStok.Model.Context.Envanter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("UrunID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunID");

                    b.ToTable("Envanters");
                });

            modelBuilder.Entity("SQStok.Model.Context.Fotograf", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DosyaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FotografVeri")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("UrunID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UrunID");

                    b.ToTable("Fotograflar");
                });

            modelBuilder.Entity("SQStok.Model.Context.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KategoriAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategories");
                });

            modelBuilder.Entity("SQStok.Model.Context.Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MarkaAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Markas");
                });

            modelBuilder.Entity("SQStok.Model.Context.MarkaKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("MarkaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.HasIndex("MarkaId");

                    b.ToTable("MarkaKategori");
                });

            modelBuilder.Entity("SQStok.Model.Context.Modeller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("MarkaId")
                        .HasColumnType("int");

                    b.Property<string>("ModelAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.HasIndex("MarkaId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("SQStok.Model.Context.Personel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AktifDurum")
                        .HasColumnType("bit");

                    b.Property<int>("BirimID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CikisTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cinsiyet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarih")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GirisTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("KullaniciAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PozisyonID")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TCNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("id");

                    b.HasIndex("BirimID");

                    b.HasIndex("PozisyonID");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("SQStok.Model.Context.Pozisyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pozisyons");
                });

            modelBuilder.Entity("SQStok.Model.Context.StokHareket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AlimSatim")
                        .HasColumnType("bit");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("UrunID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunID");

                    b.ToTable("StokHarekets");
                });

            modelBuilder.Entity("SQStok.Model.Context.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Barkod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("MarkaId")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("Renk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.HasIndex("MarkaId");

                    b.HasIndex("ModelId");

                    b.ToTable("Uruns");
                });

            modelBuilder.Entity("SQStok.Model.Context.BirimPozisyon", b =>
                {
                    b.HasOne("SQStok.Model.Context.Birim", "Birim")
                        .WithMany()
                        .HasForeignKey("BirimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQStok.Model.Context.Pozisyon", "Pozisyon")
                        .WithMany()
                        .HasForeignKey("PozisyonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Birim");

                    b.Navigation("Pozisyon");
                });

            modelBuilder.Entity("SQStok.Model.Context.Envanter", b =>
                {
                    b.HasOne("SQStok.Model.Context.Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("UrunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("SQStok.Model.Context.Fotograf", b =>
                {
                    b.HasOne("SQStok.Model.Context.Urun", "Urun")
                        .WithMany("Fotograflar")
                        .HasForeignKey("UrunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("SQStok.Model.Context.MarkaKategori", b =>
                {
                    b.HasOne("SQStok.Model.Context.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQStok.Model.Context.Marka", "Marka")
                        .WithMany()
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Marka");
                });

            modelBuilder.Entity("SQStok.Model.Context.Modeller", b =>
                {
                    b.HasOne("SQStok.Model.Context.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQStok.Model.Context.Marka", "Marka")
                        .WithMany()
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Marka");
                });

            modelBuilder.Entity("SQStok.Model.Context.Personel", b =>
                {
                    b.HasOne("SQStok.Model.Context.Birim", "Birim")
                        .WithMany()
                        .HasForeignKey("BirimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQStok.Model.Context.Pozisyon", "Pozisyon")
                        .WithMany()
                        .HasForeignKey("PozisyonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Birim");

                    b.Navigation("Pozisyon");
                });

            modelBuilder.Entity("SQStok.Model.Context.StokHareket", b =>
                {
                    b.HasOne("SQStok.Model.Context.Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("UrunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("SQStok.Model.Context.Urun", b =>
                {
                    b.HasOne("SQStok.Model.Context.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQStok.Model.Context.Marka", "Marka")
                        .WithMany()
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQStok.Model.Context.Modeller", "Modeller")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Marka");

                    b.Navigation("Modeller");
                });

            modelBuilder.Entity("SQStok.Model.Context.Urun", b =>
                {
                    b.Navigation("Fotograflar");
                });
#pragma warning restore 612, 618
        }
    }
}