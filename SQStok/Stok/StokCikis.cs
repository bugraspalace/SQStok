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
    public partial class StokCikis : Form
    {
        public StokCikis()
        {
            InitializeComponent();
        }

        private void StokCikis_Load(object sender, EventArgs e)
        {
            pictureBoxGoster.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string girilenBarkod = txtBarkod.Text.Trim();

            if (!string.IsNullOrEmpty(girilenBarkod))
            {
                using (var dbContext = new SQStokDbContext())
                {
                    var urun = dbContext.Uruns
                        .FirstOrDefault(u => u.Barkod == girilenBarkod);

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

        private void btnStokCikis_Click(object sender, EventArgs e)
        {
            string barkod = txtBarkod.Text;
            using (var context = new SQStokDbContext())
            {
                var urun = context.Uruns.FirstOrDefault(u => u.Barkod == barkod);
                if (urun != null)
                {
                    int urunId = urun.Id;
                    var envanter = context.Envanters.FirstOrDefault(x => x.UrunID == urunId);

                    // Ürün envanterde mevcut mu kontrol edin
                    if (envanter != null)
                    {
                        int satilanMiktar = int.Parse(txtStokSayi.Text);
                        if (satilanMiktar <= envanter.Adet)
                        {
                            // Stoktan satış miktarını düşürün
                            envanter.Adet -= satilanMiktar;

                            // Stok hareketi kaydı oluşturun
                            StokHareket stokHareket = new StokHareket()
                            {
                                UrunID = urunId,
                                AlimSatim = false, // Satış olduğu için false
                                Miktar = satilanMiktar,
                                Tarih = dtpStokTarih.Value,
                            };
                            context.StokHarekets.Add(stokHareket);

                            // Değişiklikleri kaydedin
                            context.SaveChanges();

                            MessageBox.Show("Stok satışı başarıyla yapıldı.");
                        }
                        else
                        {
                            MessageBox.Show("Stokta yeterli ürün bulunmamaktadır.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün envanterde bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen barkod değeri tanımsız.");
                }
            }
        }
    }
}
