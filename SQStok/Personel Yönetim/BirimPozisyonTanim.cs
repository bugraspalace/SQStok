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
    public partial class BirimPozisyonTanim : Form
    {
        public BirimPozisyonTanim()
        {
            InitializeComponent();
        }

        private void BirimPozisyonTanim_Load(object sender, EventArgs e)
        {
            cmbBirim.Items.Clear();
            using (var context = new SQStokDbContext())
            {
                var birimler = context.Birims.ToList();
                cmbBirim.DataSource = birimler;
                cmbBirim.DisplayMember = "Ad";
                cmbBirim.ValueMember = "Id";
            }
        }

        private void btnBirimKaydet_Click(object sender, EventArgs e)
        {
            using (var context = new SQStokDbContext())
            {
                Birim yeniBirim = new Birim()
                {
                    Ad = txtBirim.Text,
                };
                context.Birims.Add(yeniBirim);
                context.SaveChanges();
                MessageBox.Show("Birim başarıyla kaydedildi!");
            }
        }

        private void btnPozisyonKaydet_Click(object sender, EventArgs e)
        {
            var secilenBirim = cmbBirim.SelectedItem as Birim;

            using (var context = new SQStokDbContext())
            {
                Pozisyon yeniPozisyon = new Pozisyon()
                {
                    Ad = txtPozisyon.Text,
                };
                context.Add(yeniPozisyon);
                context.SaveChanges();

                BirimPozisyon birimPozisyon = new BirimPozisyon()
                {
                    BirimID = secilenBirim.Id,
                    PozisyonID = yeniPozisyon.Id,
                };
                context.BirimPozisyons.Add(birimPozisyon); 
                context.SaveChanges();
                MessageBox.Show("Pozisyon Başarıyla Eklendi!");
            }
        }
    }
}
