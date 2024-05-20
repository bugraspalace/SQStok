using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

namespace SQStok.Tanimlar
{
    public partial class MarkaModelTanim : Form
    {
        public MarkaModelTanim()
        {
            InitializeComponent();
        }

        private void MarkaModelTanim_Load(object sender, EventArgs e)
        {
            // Initial Load Code
            LoadKategoriList();
            LoadMarkaList();
            radioYeniMarka.Checked = true;
            txtMarkaAdi.Visible = true;
            cmbMarka.Visible = false;
            // Event Handlers for Radio Buttons
            radioYeniMarka.CheckedChanged += RadioButtons_CheckedChanged;
            radioGuncelleMarka.CheckedChanged += RadioButtons_CheckedChanged;
            using (var context = new SQStokDbContext())
            {
                var kategoriler = context.Kategories.ToList();
                comboBoxKategoriId.DataSource = kategoriler;
                comboBoxKategoriId.DisplayMember = "KategoriAd";
                comboBoxKategoriId.ValueMember = "Id";
            }


            //Kategoriye göre marka seçimi
            comboBoxKategoriId.SelectedValueChanged += (s, e) =>
            {
                comboBoxMarkaId.DataSource = null;
                if (comboBoxKategoriId.SelectedItem != null)
                {
                    using (var context2 = new SQStokDbContext())
                    {
                        int secilenKategoriId = ((Kategori)comboBoxKategoriId.SelectedItem).Id;

                        var kategoriMarkalar = context2.MarkaKategori
                        .Where(x => x.KategoriId == secilenKategoriId)
                        .Select(mk => (Marka)mk.Marka)
                        .ToList();
                        comboBoxMarkaId.DataSource = kategoriMarkalar;
                        comboBoxMarkaId.DisplayMember = "MarkaAd";
                        comboBoxMarkaId.ValueMember = "Id";
                    }
                }
            };
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYeniMarka.Checked)
            {
                txtMarkaAdi.Visible = true;
                cmbMarka.Visible = false;
            }
            else if (radioGuncelleMarka.Checked)
            {
                txtMarkaAdi.Visible = false;
                cmbMarka.Visible = true;
                LoadMarkaList();
            }
        }

        private void LoadKategoriList()
        {
            using (var context = new SQStokDbContext())
            {
                var kategoriler = context.Kategories.ToList();
                checkedListBoxMarkaKategori.DataSource = kategoriler;
                checkedListBoxMarkaKategori.DisplayMember = "KategoriAd";
                checkedListBoxMarkaKategori.ValueMember = "Id";
            }
        }

        private void LoadMarkaList()
        {
            using (var context = new SQStokDbContext())
            {
                var markalar = context.Markas.ToList();
                cmbMarka.DataSource = markalar;
                cmbMarka.DisplayMember = "MarkaAd";
                cmbMarka.ValueMember = "Id";
            }
        }

        private void btnModelKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModelAd.Text) || comboBoxMarkaId.SelectedItem == null || comboBoxKategoriId.SelectedItem == null)
            {
                MessageBox.Show("Model adı, marka ve kategori alanları boş bırakılamaz.");
                return;
            }

            using (var context = new SQStokDbContext())
            {
                // Aynı model adına sahip mevcut kaydı kontrol et
                var mevcutModel = context.Models.FirstOrDefault(m => m.ModelAd == txtModelAd.Text);

                if (mevcutModel != null)
                {
                    // Mevcut kaydı sil
                    context.Models.Remove(mevcutModel);

                    MessageBox.Show("Model Başarıyla Güncellendi");
                }
                else
                {
                    MessageBox.Show("Model Başarıyla Eklendi");
                }

                // Yeni modeli ekle
                Modeller yeniModel = new Modeller
                {
                    ModelAd = txtModelAd.Text,
                    MarkaId = Convert.ToInt32(comboBoxMarkaId.SelectedValue),
                    KategoriId = Convert.ToInt32(comboBoxKategoriId.SelectedValue),
                };
                context.Models.Add(yeniModel);
                context.SaveChanges();
            }
        }

        private void btnMarkaKaydet_Click(object sender, EventArgs e)
        {
            var secilenler = checkedListBoxMarkaKategori.CheckedItems;

            if (radioYeniMarka.Checked)
            {
                // Yeni Marka Ekleme
                if (string.IsNullOrWhiteSpace(txtMarkaAdi.Text))
                {
                    MessageBox.Show("Marka adı boş olamaz.");
                    return;
                }

                using (var context = new SQStokDbContext())
                {
                    // Marka adı zaten mevcut mu kontrol et
                    var mevcutMarka = context.Markas.SingleOrDefault(m => m.MarkaAd == txtMarkaAdi.Text);
                    if (mevcutMarka != null)
                    {
                        MessageBox.Show("Bu marka adı zaten mevcut.");
                        return;
                    }

                    Marka yeniMarka = new Marka
                    {
                        MarkaAd = txtMarkaAdi.Text,
                    };
                    context.Markas.Add(yeniMarka);
                    context.SaveChanges();

                    foreach (var item in secilenler)
                    {
                        Kategori secilenKategori = (Kategori)item;

                        // Aynı kombinasyon mevcut mu kontrol et
                        var mevcutKayit = context.MarkaKategori
                            .SingleOrDefault(mk => mk.MarkaId == yeniMarka.Id && mk.KategoriId == secilenKategori.Id);
                        if (mevcutKayit == null)
                        {
                            MarkaKategori yeniMarkaKategori = new MarkaKategori
                            {
                                MarkaId = yeniMarka.Id,
                                KategoriId = secilenKategori.Id,
                            };
                            context.MarkaKategori.Add(yeniMarkaKategori);
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show("Marka Başarıyla Eklendi!");
                }
            }
            else if (radioGuncelleMarka.Checked)
            {
                // Mevcut Marka Güncelleme
                if (cmbMarka.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen güncellenecek bir marka seçin.");
                    return;
                }

                using (var context = new SQStokDbContext())
                {
                    int secilenMarkaId = (int)cmbMarka.SelectedValue;
                    var mevcutMarka = context.Markas.SingleOrDefault(m => m.Id == secilenMarkaId);

                    if (mevcutMarka != null)
                    {
                        // Mevcut markanın kategorilerini sil
                        var mevcutKategoriler = context.MarkaKategori.Where(mk => mk.MarkaId == secilenMarkaId);
                        context.MarkaKategori.RemoveRange(mevcutKategoriler);
                        context.SaveChanges();

                        // Yeni kategorileri ekle
                        foreach (var item in secilenler)
                        {
                            Kategori secilenKategori = (Kategori)item;

                            var mevcutKayit = context.MarkaKategori
                                .SingleOrDefault(mk => mk.MarkaId == mevcutMarka.Id && mk.KategoriId == secilenKategori.Id);
                            if (mevcutKayit == null)
                            {
                                MarkaKategori yeniMarkaKategori = new MarkaKategori
                                {
                                    MarkaId = mevcutMarka.Id,
                                    KategoriId = secilenKategori.Id,
                                };
                                context.MarkaKategori.Add(yeniMarkaKategori);
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show("Marka Başarıyla Güncellendi!");
                    }
                }
            }
        }
    }
}
