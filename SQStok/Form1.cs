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
                return; // Bo� alan varsa i�lemi sonland�r
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
                    MessageBox.Show("giri� ba�ar�l�!");
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� veya �ifre hatal�.");
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

            // Kullan�c� ad� ve �ifre alanlar�n�n durumlar�na g�re i�lem yap
            if (kullaniciAdiBos || sifreBos)
            {
                // Kullan�c� ad� veya �ifre bo�sa, TextBox'lar�n yan�ndaki Label'larda y�ld�z g�ster
                if (kullaniciAdiBos)
                {
                    lblUsername.Text = "*";
                    lblUsername.ForeColor = Color.Red; // Y�ld�z rengini k�rm�z� olarak ayarla
                    MessageBox.Show("Kullan�c� ad� alan� bo� b�rak�lamaz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lblUsername.Text = ""; // Kullan�c� ad� doluysa sembol� kald�r
                }

                if (sifreBos)
                {
                    lblPassword.Text = "*";
                    lblPassword.ForeColor = Color.Red; // Y�ld�z rengini k�rm�z� olarak ayarla
                    MessageBox.Show("�ifre alan� bo� b�rak�lamaz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lblPassword.Text = ""; // �ifre doluysa sembol� kald�r
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
