using SQStok.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQStok.Personel_Yönetim
{
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            using (var context = new SQStokDbContext())
            {
                var data = context.Personels.Select(p => new
                {
                    p.Ad,
                    p.Soyad,
                    p.DogumTarih,
                    p.TCNo,
                    p.Tel,
                    p.Mail,
                    p.Cinsiyet,
                    p.KullaniciAd,
                    Sifre = new string('\u25CF', p.Sifre.Length),
                    BirimAd = p.Birim.Ad, // Assuming 'BirimAd' property exists in 'Birim' class
                    PozisyonAd = p.Pozisyon.Ad, // Assuming 'PozisyonAd' property exists in 'Pozisyon' class
                    p.GirisTarih,
                    p.CikisTarih,
                    p.AktifDurum,
                }).ToList();

                dataGridView1.DataSource = data;

                // ID kolonunu kaldır
                //dataGridView1.Columns["id"].Visible = false;
                // Şifre kolonunu gizle
                //dataGridView1.Columns["Sifre"].Visible = false;
                // Birim adını getir
                //dataGridView1.Columns["BirimAd"].DataPropertyName = "Birim.BirimAd";
                //dataGridView1.Columns["PozisyonAd"].DataPropertyName = "Pozisyon.PozisyonAd";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
