using Microsoft.EntityFrameworkCore;
using SQStok.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQStok.Stok
{
    public partial class StokGiris : Form
    {
        public StokGiris()
        {
            InitializeComponent();
        }

        private void StokGiris_Load(object sender, EventArgs e)
        {
            pictureBoxGoster.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnStokGiris_Click(object sender, EventArgs e)
        {
            string barkod = txtBarkod.Text;

            // Adet bilgisinin kontrolü
            if (string.IsNullOrWhiteSpace(txtStokSayi.Text))
            {
                MessageBox.Show("Lütfen adet bilgisini giriniz.");
                return;
            }

            int adet;
            if (!int.TryParse(txtStokSayi.Text, out adet) || adet <= 0)
            {
                MessageBox.Show("Geçerli bir adet giriniz (pozitif tam sayı).");
                return;
            }

            using (var context = new SQStokDbContext())
            {
                var urun = context.Uruns
                    .Include(u => u.Fotograflar) // Ürünün fotoğraflarını da yükle
                    .FirstOrDefault(u => u.Barkod == barkod);

                if (urun != null)
                {
                    int urunId = urun.Id;
                    var envanter = context.Envanters.FirstOrDefault(x => x.UrunID == urunId);

                    // Ürün daha önce satın alındıysa mevcut envanter satırındaki adet miktarını artırın
                    if (envanter != null)
                    {
                        envanter.Adet += adet;
                    }
                    else
                    {
                        // Ürün ilk kez satın alınıyorsa yeni bir envanter satırı oluşturun
                        Envanter yeniStok = new Envanter()
                        {
                            UrunID = urunId,
                            Adet = adet,
                        };
                        context.Envanters.Add(yeniStok);
                    }

                    // Stok hareketi kaydı oluşturun
                    StokHareket stokHareket = new StokHareket()
                    {
                        UrunID = urunId,
                        AlimSatim = true, // true: Alış, false: Satış
                        Miktar = adet,
                        Tarih = dtpStokTarih.Value, // Tarih kontrolünden tarihi al
                    };
                    context.StokHarekets.Add(stokHareket);

                    // Değişiklikleri kaydedin
                    context.SaveChanges();

                    // Ürün fotoğrafını göster (eğer varsa)
                    if (urun.Fotograflar.Any())
                    {
                        var fotografVerisi = urun.Fotograflar.First().FotografVeri; // İlk fotoğrafı al
                        using (MemoryStream ms = new MemoryStream(fotografVerisi))
                        {
                            pictureBoxGoster.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBoxGoster.Image = null; // Fotoğraf yoksa pictureBox'ı temizle
                    }

                    MessageBox.Show("Stok girişi başarıyla yapıldı.");
                }
                else
                {
                    MessageBox.Show("Girilen barkod değeri tanımsız.");
                    pictureBoxGoster.Image = null; // Barkod tanımsızsa pictureBox'ı temizle
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string girilenBarkod = txtBarkod.Text.Trim();

            if (!string.IsNullOrEmpty(girilenBarkod))
            {
                using (var dbContext = new SQStokDbContext())
                {
                    var urun = dbContext.Uruns.FirstOrDefault(u => u.Barkod == girilenBarkod);

                    if (urun != null)
                    {
                        txtUrunAd.Text = urun.Ad;
                        txtBarkod.Text = urun.Barkod;
                        txtUrunRenk.Text = urun.Renk;
                        labelUrunBulunduBulunamadi.ForeColor = Color.Green;
                        labelUrunBulunduBulunamadi.Text = "Ürün Bulundu";

                        // Ürünün fotoğrafını gösterme
                        FotografiGoster(urun.Id);
                    }
                    else
                    {
                        labelUrunBulunduBulunamadi.ForeColor = Color.Red;
                        labelUrunBulunduBulunamadi.Text = "Ürün Bulunamadı";
                        pictureBoxGoster.Image = null; // Eğer ürün bulunamadıysa, PictureBox'ı temizle
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir barkod girin.");
            }
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {

        }
        private void FotografiGoster(int urunID)
        {
            using (var dbContext = new SQStokDbContext())
            {
                Fotograf fotograf = dbContext.Fotograflar.FirstOrDefault(f => f.UrunID == urunID);

                if (fotograf != null)
                {
                    byte[] fotografBytes = fotograf.FotografVeri;
                    Image image = ByteArrayToImage(fotografBytes);

                    // PictureBox veya başka bir kontrol üzerinde gösterme
                    pictureBoxGoster.Image = image;
                }
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void pictureBoxGoster_Click(object sender, EventArgs e)
        {

        }
    }
}
