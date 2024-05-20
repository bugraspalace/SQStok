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
    public partial class UrunTanim : Form
    {
        public UrunTanim()
        {
            InitializeComponent();
        }

        private void UrunTanim_Load(object sender, EventArgs e)
        {
            pictureBoxResim.SizeMode = PictureBoxSizeMode.Zoom;

            using (var context = new SQStokDbContext())
            {
                comboBoxKategori.Items.Clear();
                comboBoxMarka.Items.Clear();
                comboBoxModel.Items.Clear();

                var kategoriler = context.Kategories.ToList();
                comboBoxKategori.DataSource = kategoriler;
                comboBoxKategori.DisplayMember = "KategoriAd";
                comboBoxKategori.ValueMember = "Id";

                //Kategoriye göre marka seçimi
                comboBoxKategori.SelectedValueChanged += (s, e) =>
                {
                    comboBoxMarka.DataSource = null;
                    if (comboBoxKategori.SelectedItem != null)
                    {
                        using (var context2 = new SQStokDbContext())
                        {
                            int secilenKategoriId = ((Kategori)comboBoxKategori.SelectedItem).Id;

                            var kategoriMarkalar = context2.MarkaKategori
                            .Where(x => x.KategoriId == secilenKategoriId)
                            .Select(mk => (Marka)mk.Marka)
                            .ToList();
                            comboBoxMarka.DataSource = kategoriMarkalar;
                            comboBoxMarka.DisplayMember = "MarkaAd";
                            comboBoxMarka.ValueMember = "Id";
                        }
                    }
                };
                comboBoxMarka.SelectedValueChanged += (s, e) =>
                {
                    if (comboBoxMarka.SelectedItem != null)
                    {
                        using (var context3 = new SQStokDbContext())
                        {
                            int secilenMarkaId = ((Marka)comboBoxMarka.SelectedItem).Id;
                            int secilenKategoriId = ((Kategori)comboBoxKategori.SelectedItem).Id;
                            var markaModeller = GetModellerByMarkaAndKategori(secilenMarkaId, secilenKategoriId);
                            comboBoxModel.DataSource = markaModeller;
                            comboBoxModel.DisplayMember = "ModelAd";
                            comboBoxModel.ValueMember = "Id";
                        }
                    }
                };
            }
        }
        public List<Modeller> GetModellerByMarkaAndKategori(int markaId, int kategoriId)
        {
            using (var context = new SQStokDbContext())
            {
                // MarkaId'ye ve KategoriId'ye göre Modeller tablosundan ilgili modelleri seç   
                return context.Models
                    .Where(m => m.MarkaId == markaId && m.KategoriId == kategoriId)
                    .ToList();
            }
        }

        private void btnEkleUrun_Click(object sender, EventArgs e)
        {
            // Boş değer kontrolü
            if (string.IsNullOrWhiteSpace(txtUrunAd.Text) ||
                string.IsNullOrWhiteSpace(txtBarkod.Text) ||
                string.IsNullOrWhiteSpace(richTxtAciklama.Text) ||
                string.IsNullOrWhiteSpace(txtRenk.Text) ||
                comboBoxMarka.SelectedItem == null ||
                comboBoxModel.SelectedItem == null ||
                comboBoxKategori.SelectedItem == null ||
                imageBytes == null || imageBytes.Length == 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz ve bir resim seçiniz.");
                return;
            }

            using (var dbContext = new SQStokDbContext())
            {
                // Yeni ürün oluşturma
                Urun yeniUrun = new Urun
                {
                    Ad = txtUrunAd.Text,
                    Barkod = txtBarkod.Text,
                    Aciklama = richTxtAciklama.Text,
                    Renk = txtRenk.Text,
                    MarkaId = Convert.ToInt32(comboBoxMarka.SelectedValue),
                    ModelId = Convert.ToInt32(comboBoxModel.SelectedValue),
                    KategoriId = Convert.ToInt32(comboBoxKategori.SelectedValue),
                };

                // Yeni fotoğraf oluşturma ve ilişkilendirme
                Fotograf yeniFotograf = new Fotograf
                {
                    DosyaAdi = "image.jpg", // İsteğe bağlı olarak dosya adını değiştirebilirsiniz
                    FotografVeri = imageBytes,
                    Urun = yeniUrun
                };

                // Veritabanına eklemeleri yapma
                dbContext.Uruns.Add(yeniUrun);
                dbContext.Fotograflar.Add(yeniFotograf);
                dbContext.SaveChanges();

                MessageBox.Show("Ürün ve resim başarıyla veritabanına kaydedildi.");
            }
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxModel_SelectedIndexChasdasdanged(object sender, EventArgs e)
        {
        }
        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog.FileName;
                Image image = Image.FromFile(dosyaYolu);
                pictureBoxResim.Image = image; // PictureBox üzerinde gösterme

                // Resmi byte dizisine dönüştürme
                imageBytes = ResmiByteDizisineDonustur(image);
            }
        }

        private byte[] ResmiByteDizisineDonustur(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                return memoryStream.ToArray();
            }
        }

        private byte[] imageBytes;
    }
}
