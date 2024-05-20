using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace SQStok.Model.Context
{
    public class PersonelConfiguration : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.Ad).HasMaxLength(50);
            builder.Property(x => x.Soyad).HasMaxLength(50);
            builder.Property(x => x.TCNo).HasMaxLength(11);
            builder.Property(x => x.Tel).HasMaxLength(11);
            builder.Property(x => x.Mail).HasMaxLength(50);
            builder.Property(x => x.KullaniciAd).HasMaxLength(50);
            builder.Property(x => x.Sifre).HasMaxLength(50);
        }
    }
    public class Personel
    {
        [Key]
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarih { get; set; }
        public string TCNo { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Cinsiyet { get; set; }
        public string KullaniciAd { get; set; }

        public string Sifre { get; set; }
        public int BirimID { get; set; }
        public Birim Birim { get; set; }

        public int PozisyonID { get; set; }
        public Pozisyon Pozisyon { get; set; }

        public DateTime GirisTarih { get; set; }
        public DateTime? CikisTarih { get; set; }
        public bool AktifDurum { get; set; }

    }
}