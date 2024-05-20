using Microsoft.VisualBasic.ApplicationServices;
using SQStok.Model.Context;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQStok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string KullaniciAdi { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = girisYapbtn;
        }

        private void girisYapbtn_Click_1(object sender, EventArgs e)
        {
            BosAlanlariVurgula();

            string kullaniciadi = kullaniciAditxt.Text;
            string sifre = kullaniciSifretxt.Text;

            string username = kullaniciAditxt.Text.Trim();
            string password = kullaniciSifretxt.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(sifre))
            {
                return; // Boþ alan varsa iþlemi sonlandýr
            }

            using (var db = new SQStokDbContext())
            {
                //var pozisyon = db.Personels.Where(p => p.KullaniciAd == kullaniciadi && p.Sifre == sifre).Select(x => x.Pozisyon).FirstOrDefault();

                //if(pozisyon == "asdasd")
                //{
                //    //goster 

                //    //gosterme
                //}

                var personelIsExist = db.Personels.Any(p => p.KullaniciAd == kullaniciadi && p.Sifre == sifre);
                if (personelIsExist == true)
                {
                    KullaniciAdi = kullaniciadi;
                    MessageBox.Show("giriþ baþarýlý!");
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý veya þifre hatalý.");
                }
            }
        }

        private void kullaniciSifretxt_TextChanged(object sender, EventArgs e)
        {
            kullaniciSifretxt.PasswordChar = '\u25CF';
        }

        private void BosAlanlariVurgula()
        {
            string kullaniciAdi = kullaniciAditxt.Text.Trim();
            string sifre = kullaniciSifretxt.Text.Trim();
            bool kullaniciAdiBos = string.IsNullOrEmpty(kullaniciAdi);
            bool sifreBos = string.IsNullOrEmpty(sifre);

            // Kullanýcý adý ve þifre alanlarýnýn durumlarýna göre iþlem yap
            if (kullaniciAdiBos || sifreBos)
            {
                // Kullanýcý adý veya þifre boþsa, TextBox'larýn yanýndaki Label'larda yýldýz göster
                if (kullaniciAdiBos)
                {
                    lblUsername.Text = "*";
                    lblUsername.ForeColor = Color.Red; // Yýldýz rengini kýrmýzý olarak ayarla
                    MessageBox.Show("Kullanýcý adý alaný boþ býrakýlamaz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lblUsername.Text = ""; // Kullanýcý adý doluysa sembolü kaldýr
                }

                if (sifreBos)
                {
                    lblPassword.Text = "*";
                    lblPassword.ForeColor = Color.Red; // Yýldýz rengini kýrmýzý olarak ayarla
                    MessageBox.Show("Þifre alaný boþ býrakýlamaz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lblPassword.Text = ""; // Þifre doluysa sembolü kaldýr
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
