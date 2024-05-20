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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQStok.Personel_Yönetim
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            using (var context = new SQStokDbContext())
            {
                birimCombobox.Items.Clear();
                pozisyonCombobox.Items.Clear();

                var birimler = context.Birims.ToList();
                birimCombobox.DataSource = birimler;
                birimCombobox.DisplayMember = "Ad";
                birimCombobox.ValueMember = "Id";

                birimCombobox.SelectedValueChanged += (s, e) =>
                {
                    pozisyonCombobox.DataSource = null;
                    if (birimCombobox.SelectedItem != null)
                    {
                        using (var context2 = new SQStokDbContext())
                        {
                            int secilenBirim = ((Birim)birimCombobox.SelectedItem).Id;

                            var birimPozisyonIDs = context2.BirimPozisyons
                                .Where(x => x.BirimID == secilenBirim)
                                .Select(mk => mk.PozisyonID)
                                .ToList();

                            var pozisyonlar = context2.Pozisyons
                                .Where(p => birimPozisyonIDs.Contains(p.Id))
                                .ToList();

                            pozisyonCombobox.DataSource = pozisyonlar;
                            pozisyonCombobox.DisplayMember = "Ad";
                            pozisyonCombobox.ValueMember = "Id";
                        }
                    }
                };
            }
        }
        private void birimCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void pozisyonCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void personelEklebtn_Click(object sender, EventArgs e)
        {
            string personelCinsiyet;
            if (radioErkek.Checked) { personelCinsiyet = "Erkek"; }
            else { personelCinsiyet = "Kadın"; }

            using (var context = new SQStokDbContext())
            {
                int secilenBirimID = ((Birim)birimCombobox.SelectedItem).Id; // Doğru birim ID'sini al
                int secilenPozisyonID = ((Pozisyon)pozisyonCombobox.SelectedItem).Id; // Doğru pozisyon ID'sini al

                Personel yeniPersonel = new Personel
                {
                    Ad = personelAdtxt.Text,
                    Soyad = personelSoyadtxt.Text,
                    DogumTarih = dateDogumTarih.Value,
                    TCNo = tcNotxt.Text,
                    Tel = telefonNotxt.Text,
                    Mail = ePostatxt.Text,
                    Cinsiyet = personelCinsiyet,
                    KullaniciAd = personeKullaniciAdtxt.Text,
                    Sifre = personelSifretxt.Text,
                    BirimID = secilenBirimID, // Doğru birim ID'sini at
                    PozisyonID = secilenPozisyonID, // Doğru pozisyon ID'sini at
                    GirisTarih = DateTime.Now.Date,
                    AktifDurum = true,
                };
                context.Personels.Add(yeniPersonel);
                context.SaveChanges();
                MessageBox.Show("Personel Başarıyla Eklendi.");
            }
        }
    }
}

