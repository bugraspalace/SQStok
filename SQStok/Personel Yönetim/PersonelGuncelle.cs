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

namespace SQStok.Personel_Yönetim
{
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            LoadPersoneller();
            dgwGuncellePersonel.SelectionChanged += DgwGuncellePersonel_SelectionChanged;
        }

        private void LoadPersoneller()
        {
            using (var context = new SQStokDbContext())
            {
                var personeller = context.Personels
                    .Select(p => new
                    {
                        p.id,
                        p.Ad,
                        p.Soyad,
                        p.TCNo,
                        p.Tel,
                        p.Mail,
                        p.Cinsiyet,
                        p.KullaniciAd,
                        Birim = p.Birim.Ad,
                        Pozisyon = p.Pozisyon.Ad,
                        p.AktifDurum
                    })
                    .ToList();

                dgwGuncellePersonel.DataSource = personeller;

                // Id kolonunu gizle
                dgwGuncellePersonel.Columns["Id"].Visible = false;
            }
        }

        private void DgwGuncellePersonel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwGuncellePersonel.SelectedRows.Count > 0)
            {
                int selectedPersonelId = (int)dgwGuncellePersonel.SelectedRows[0].Cells["Id"].Value;

                using (var context = new SQStokDbContext())
                {
                    var personel = context.Personels.Find(selectedPersonelId);
                    if (personel != null)
                    {
                        personelAdtxt.Text = personel.Ad;
                        personelSoyadtxt.Text = personel.Soyad;
                        dateDogumTarih.Value = personel.DogumTarih;
                        tcNotxt.Text = personel.TCNo;
                        telefonNotxt.Text = personel.Tel;
                        ePostatxt.Text = personel.Mail;
                        radioErkek.Checked = personel.Cinsiyet == "Erkek";
                        radioKadin.Checked = personel.Cinsiyet == "Kadın";
                        personeKullaniciAdtxt.Text = personel.KullaniciAd;
                        personelSifretxt.Text = personel.Sifre;

                        var birimler = context.Birims.ToList();
                        birimCombobox.DataSource = birimler;
                        birimCombobox.DisplayMember = "Ad";
                        birimCombobox.ValueMember = "Id";
                        birimCombobox.SelectedValue = personel.BirimID;

                        int secilenBirimID = personel.BirimID;
                        var pozisyonlar = context.BirimPozisyons
                            .Where(bp => bp.BirimID == secilenBirimID)
                            .Select(bp => bp.Pozisyon)
                            .ToList();

                        pozisyonCombobox.DataSource = pozisyonlar;
                        pozisyonCombobox.DisplayMember = "Ad";
                        pozisyonCombobox.ValueMember = "Id";
                        pozisyonCombobox.SelectedValue = personel.PozisyonID;
                    }
                }
            }
        }

        private void personelGuncellebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(personelAdtxt.Text) ||
                string.IsNullOrWhiteSpace(personelSoyadtxt.Text) ||
                string.IsNullOrWhiteSpace(tcNotxt.Text) ||
                string.IsNullOrWhiteSpace(telefonNotxt.Text) ||
                string.IsNullOrWhiteSpace(ePostatxt.Text) ||
                string.IsNullOrWhiteSpace(personeKullaniciAdtxt.Text) ||
                string.IsNullOrWhiteSpace(personelSifretxt.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new SQStokDbContext())
            {
                if (dgwGuncellePersonel.SelectedRows.Count > 0)
                {
                    int selectedPersonelId = (int)dgwGuncellePersonel.SelectedRows[0].Cells["Id"].Value;
                    var personel = context.Personels.Find(selectedPersonelId);

                    if (personel != null)
                    {
                        personel.Ad = personelAdtxt.Text;
                        personel.Soyad = personelSoyadtxt.Text;
                        personel.DogumTarih = dateDogumTarih.Value;
                        personel.TCNo = tcNotxt.Text;
                        personel.Tel = telefonNotxt.Text;
                        personel.Mail = ePostatxt.Text;
                        personel.Cinsiyet = radioErkek.Checked ? "Erkek" : "Kadın";
                        personel.KullaniciAd = personeKullaniciAdtxt.Text;
                        personel.Sifre = personelSifretxt.Text;
                        personel.BirimID = ((Birim)birimCombobox.SelectedItem).Id;
                        personel.PozisyonID = ((Pozisyon)pozisyonCombobox.SelectedItem).Id;

                        context.SaveChanges();
                        MessageBox.Show("Personel Başarıyla Güncellendi.");
                        LoadPersoneller(); // Güncellenmiş verileri yeniden yükle
                    }
                }
            }
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            using (var context = new SQStokDbContext())
            {
                var filteredPersoneller = new List<object>();

                if (radioAdSoyad.Checked)
                {
                    string searchValue = txtSearch.Text.ToLower();
                    filteredPersoneller = context.Personels
                        .Where(p => (p.Ad + " " + p.Soyad).ToLower().Contains(searchValue))
                        .Select(p => new
                        {
                            p.id,
                            p.Ad,
                            p.Soyad,
                            p.TCNo,
                            p.Tel,
                            p.Mail,
                            p.Cinsiyet,
                            p.KullaniciAd,
                            Birim = p.Birim.Ad,
                            Pozisyon = p.Pozisyon.Ad,
                            p.AktifDurum
                        })
                        .ToList<object>();
                }
                else if (radioTC.Checked)
                {
                    string searchValue = txtSearch.Text;
                    filteredPersoneller = context.Personels
                        .Where(p => p.TCNo.Contains(searchValue))
                        .Select(p => new
                        {
                            p.id,
                            p.Ad,
                            p.Soyad,
                            p.TCNo,
                            p.Tel,
                            p.Mail,
                            p.Cinsiyet,
                            p.KullaniciAd,
                            Birim = p.Birim.Ad,
                            Pozisyon = p.Pozisyon.Ad,
                            p.AktifDurum
                        })
                        .ToList<object>();
                }
                else
                {
                    MessageBox.Show("Lütfen bir arama kriteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (filteredPersoneller.Any())
                {
                    dgwGuncellePersonel.DataSource = filteredPersoneller;
                }
                else
                {
                    MessageBox.Show("Arama kriterlerine uyan personel bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwGuncellePersonel.DataSource = null;
                }
            }
        }
    }
}

