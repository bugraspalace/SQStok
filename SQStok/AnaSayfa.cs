using SQStok.Personel_Yönetim;
using SQStok.Stok;
using SQStok.Tanimlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQStok
{
    public partial class AnaSayfa : Form
    {
        private Form aktifForm = null;

        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelAktifKullanici.Text = "Aktif Kullanıcı : " + Form1.KullaniciAdi;

            if (Form1.KullaniciAdi == "admin")
            {
                tanimlarToolStripMenuItem.Visible = true;
                this.Show();
            }
            else
            {
                tanimlarToolStripMenuItem.Visible = false;
            }
        }
        private void FormAc(Form yeniForm)
        {
            if (aktifForm != null)
            {
                aktifForm.Close();
            }

            aktifForm = yeniForm;
            aktifForm.MdiParent = this; // MDI parent olarak ayarla   
            aktifForm.WindowState = FormWindowState.Maximized; // Tam ekran yap   
            aktifForm.Show();
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            FormAc(personeller);
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            FormAc(personelEkle);
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kategoriTanimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriTanim kategoriTanim = new KategoriTanim();
            FormAc(kategoriTanim);
        }

        private void urunTanimToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UrunTanim urunTanim = new UrunTanim();
            FormAc(urunTanim);
        }

        private void markaModelTanimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaModelTanim markaModelTanim = new MarkaModelTanim();
            FormAc(markaModelTanim);
        }

        private void birimPozisyonTanimToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void satınAlımİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokGiris stokGiris = new StokGiris();
            FormAc(stokGiris);
        }

        private void satışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokCikis stokCikis = new StokCikis();
            FormAc(stokCikis);
        }

        private void stokHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokAlimSatim stokAlimSatim = new StokAlimSatim();
            FormAc(stokAlimSatim);
        }

        private void birimPozisyonTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BirimPozisyonTanim birimPozisyonTanim = new BirimPozisyonTanim();
            FormAc(birimPozisyonTanim);
        }

        private void personelSilGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelGuncelle personelGuncelle = new PersonelGuncelle();
            FormAc(personelGuncelle);
        }
    }
}
