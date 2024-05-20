using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace SQStok.Model.Context
{
    public class SQStokDbContext : DbContext
    {
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Kategori> Kategories { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Modeller> Models { get; set; }
        public DbSet<Birim> Birims { get; set; }
        public DbSet<Pozisyon> Pozisyons { get; set; }
        public DbSet<MarkaKategori> MarkaKategori { get; set; }
        public DbSet<StokHareket> StokHarekets { get; set; }
        public DbSet<Fotograf> Fotograflar { get; set; }
        public DbSet<Envanter> Envanters { get; set; }
        public DbSet<BirimPozisyon> BirimPozisyons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Urun>()
            //    .Property(u => u.KDVOran)
            //    .HasColumnType("decimal(18, 2)");

            //modelBuilder.Entity<Urun>()
            //    .Property(u => u.MaliyetFiyat)
            //    .HasColumnType("decimal(18, 2)");

            //modelBuilder.Entity<Urun>()
            //    .Property(u => u.SatisFiyat)
            //    .HasColumnType("decimal(18, 2)");

            //modelBuilder.Entity<Urun>()
            //    .Property(u => u.Agirlik)
            //    .HasColumnType("decimal(18, 2)");


            //POZISYON FOREIGNKEY TANIMLAMASI

            modelBuilder.Entity<MarkaKategori>()
                .HasOne(x => x.Kategori)
                .WithMany()
                .HasForeignKey(u => u.KategoriId);
            modelBuilder.Entity<MarkaKategori>()
                .HasOne(x => x.Marka)
                .WithMany()
                .HasForeignKey(a => a.MarkaId);

            modelBuilder.Entity<Modeller>()
                .HasOne(x => x.Kategori)
                .WithMany()
                .HasForeignKey(a => a.KategoriId);

            modelBuilder.Entity<Modeller>()
                .HasOne(x => x.Marka)
                .WithMany()
                .HasForeignKey(a => a.MarkaId);
            modelBuilder.Entity<Urun>()
                .HasOne(x => x.Kategori)
                .WithMany()
                .HasForeignKey(a => a.KategoriId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Urun>()
                .HasOne(x => x.Marka)
                .WithMany()
                .HasForeignKey(a => a.MarkaId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Urun>()
                .HasOne(x => x.Modeller)
                .WithMany()
                .HasForeignKey(a => a.ModelId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<StokHareket>()
                .HasOne(x => x.Urun)
                .WithMany()
                .HasForeignKey(x => x.UrunID)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Fotograf>()
                .HasOne(f => f.Urun)
                .WithMany(u => u.Fotograflar)
                .IsRequired();
            modelBuilder.Entity<Envanter>()
                .HasOne(f => f.Urun)
                .WithMany()
                .HasForeignKey(a => a.UrunID)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<BirimPozisyon>()
                .HasOne(x => x.Birim)
                .WithMany()
                .HasForeignKey(a => a.BirimID);
            modelBuilder.Entity<BirimPozisyon>()
                .HasOne(x => x.Pozisyon)
                .WithMany()
                .HasForeignKey(x => x.PozisyonID);
            modelBuilder.ApplyConfiguration(new PersonelConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=EMREHALIM\\SQLEXPRESS;Database=SQStok;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }

}
