using SQStok.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQStok.Stok
{
    public partial class StokAlimSatim : Form
    {
        public StokAlimSatim()
        {
            InitializeComponent();
        }
        private void StokAlimSatim_Load(object sender, EventArgs e)
        {
            var context = new SQStokDbContext();

            cmbKategori.Items.Clear();
            cmbMarka.Items.Clear();
            cmbModel.Items.Clear();

            radioGunluk.Checked = true;
            dtpBaslangicTarih.Enabled = false;
            dtpBitisTarih.Enabled = false;

            var kategoriler = context.Kategories.ToList();
            kategoriler.Insert(0, new Kategori { KategoriAd = "Hepsi", Id = -1 });

            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "Id";

            cmbKategori.SelectedValueChanged += (s, ev) =>
            {
                if (cmbKategori.SelectedItem != null)
                {
                    var selectedKategori = cmbKategori.SelectedItem as Kategori;
                    if (selectedKategori.Id == -1) // "Hepsi" seçildi
                    {
                        var modeller = context.Models.ToList();
                        modeller.Insert(0, new Modeller { ModelAd = "Hepsi", Id = -1 });

                        cmbMarka.DataSource = context.Markas.ToList();
                        cmbMarka.DisplayMember = "MarkaAd";
                        cmbMarka.ValueMember = "Id";

                        cmbModel.DataSource = modeller;
                        cmbModel.DisplayMember = "ModelAd";
                        cmbModel.ValueMember = "Id";
                    }
                    else // Kategori seçimi yapıldı
                    {
                        var kategoriMarkalar = context.MarkaKategori
                            .Where(x => x.KategoriId == selectedKategori.Id)
                            .Select(mk => mk.Marka)
                            .ToList();
                        kategoriMarkalar.Insert(0, new Marka { MarkaAd = "Hepsi", Id = -1 });

                        cmbMarka.DataSource = kategoriMarkalar;
                        cmbMarka.DisplayMember = "MarkaAd";
                        cmbMarka.ValueMember = "Id";
                    }
                }
            };

            cmbMarka.SelectedValueChanged += (s, ev) =>
            {
                if (cmbMarka.SelectedItem != null)
                {
                    var selectedMarka = cmbMarka.SelectedItem as Marka;
                    if (selectedMarka.Id != -1) // "Hepsi" dışında bir marka seçildi
                    {
                        var markaModeller = context.Models
                            .Where(m => m.MarkaId == selectedMarka.Id)
                            .ToList();
                        markaModeller.Insert(0, new Modeller { ModelAd = "Hepsi", Id = -1 });

                        cmbModel.DataSource = markaModeller;
                        cmbModel.DisplayMember = "ModelAd";
                        cmbModel.ValueMember = "Id";
                    }
                }
            };

        }


        public List<Modeller> GetModellerByMarkaAndKategori(int markaId, int kategoriId)
        {
            using (var context = new SQStokDbContext())
            {
                return context.Models
                    .Where(m => m.MarkaId == markaId && m.KategoriId == kategoriId)
                    .ToList();
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            // Seçilen marka, model ve kategori ID'lerini alın
            int markaId = (int)cmbMarka.SelectedValue;
            int modelId = (int)cmbModel.SelectedValue;
            int kategoriId = (int)cmbKategori.SelectedValue;

            // Tarih aralığını belirle
            DateTime tarihGeriyeGit = DateTime.Now;
            if (radioGunluk.Checked)
            {
                tarihGeriyeGit = tarihGeriyeGit.AddDays(-1);
            }
            else if (radioHaftalik.Checked)
            {
                tarihGeriyeGit = tarihGeriyeGit.AddDays(-7);
            }
            else if (radioAylik.Checked)
            {
                tarihGeriyeGit = tarihGeriyeGit.AddDays(-30);
            }

            using (var context = new SQStokDbContext())
            {
                IQueryable<StokHareket> stokHareketQuery = context.StokHarekets;

                // Tarihe göre filtreleme yap
                if (radiOzel.Checked)
                {
                    DateTime baslangicTarih = dtpBaslangicTarih.Value;
                    DateTime bitisTarih = dtpBitisTarih.Value;

                    stokHareketQuery = stokHareketQuery.Where(s => s.Tarih >= baslangicTarih && s.Tarih <= bitisTarih);
                }
                else
                {
                    stokHareketQuery = stokHareketQuery.Where(s => s.Tarih >= tarihGeriyeGit);
                }

                // Marka, model ve kategori ID'lerine göre filtreleme yap
                if (markaId != -1)
                {
                    stokHareketQuery = stokHareketQuery.Where(s => s.Urun.MarkaId == markaId);
                }
                if (modelId != -1)
                {
                    stokHareketQuery = stokHareketQuery.Where(s => s.Urun.ModelId == modelId);
                }
                if (kategoriId != -1)
                {
                    stokHareketQuery = stokHareketQuery.Where(s => s.Urun.KategoriId == kategoriId);
                }

                // Sonuçları al ve DataGridView'e bind et
                var stokHareketleri = stokHareketQuery.Select(sh => new
                {
                    Tarih = sh.Tarih, // Tarih sütunu eklendi
                    AlimSatim = sh.AlimSatim ? "Satın Alım" : "Satış İşlemi",
                    Miktar = sh.Miktar,
                    Urun = sh.Urun.Ad
                }).ToList();

                // DataGridView'e verileri aktar
                dgwListe.DataSource = stokHareketleri;
            }
        }
        private void panelFiltre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioHaftalik_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiOzel_CheckedChanged(object sender, EventArgs e)
        {
            if (radiOzel.Checked)
            {
                dtpBaslangicTarih.Enabled = true;
                dtpBitisTarih.Enabled = true;
            }
            else
            {
                dtpBaslangicTarih.Enabled = false;
                dtpBitisTarih.Enabled = false;
            }
        }
    }
}
