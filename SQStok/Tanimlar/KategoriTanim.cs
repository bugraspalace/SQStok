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
    public partial class KategoriTanim : Form
    {
        public KategoriTanim()
        {
            InitializeComponent();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAd.Text) || string.IsNullOrWhiteSpace(richTxtAciklama.Text))
            {
                MessageBox.Show("Kategori Adı ve Açıklama boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop processing if fields are empty
            }

            using (var context = new SQStokDbContext())
            {
                // Check if the category name already exists in the database
                bool categoryExists = context.Kategories.Any(k => k.KategoriAd == txtKategoriAd.Text);
                if (categoryExists)
                {
                    MessageBox.Show("Bu isimde bir kategori zaten var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop processing if category exists
                }

                // Create a new category and save it to the database
                Kategori yeniKategori = new Kategori
                {
                    KategoriAd = txtKategoriAd.Text,
                    KategoriAciklama = richTxtAciklama.Text,
                };
                context.Kategories.Add(yeniKategori);
                context.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
