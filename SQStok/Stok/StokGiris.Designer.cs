namespace SQStok.Stok
{
    partial class StokGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            dtpStokTarih = new DateTimePicker();
            txtStokSayi = new TextBox();
            btnStokGiris = new Button();
            txtBarkod = new TextBox();
            btnSearch = new Button();
            label4 = new Label();
            txtUrunAd = new TextBox();
            txtUrunBarkod = new TextBox();
            txtUrunRenk = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelUrunBulunduBulunamadi = new Label();
            pictureBoxGoster = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoster).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 78);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Barkod";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 112);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Tarih";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 146);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Adet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(80, 9);
            label5.Name = "label5";
            label5.Size = new Size(150, 37);
            label5.TabIndex = 4;
            label5.Text = "STOK GİRİŞ";
            // 
            // dtpStokTarih
            // 
            dtpStokTarih.Location = new Point(64, 106);
            dtpStokTarih.Name = "dtpStokTarih";
            dtpStokTarih.Size = new Size(200, 23);
            dtpStokTarih.TabIndex = 6;
            // 
            // txtStokSayi
            // 
            txtStokSayi.Location = new Point(64, 143);
            txtStokSayi.Name = "txtStokSayi";
            txtStokSayi.Size = new Size(200, 23);
            txtStokSayi.TabIndex = 7;
            // 
            // btnStokGiris
            // 
            btnStokGiris.Location = new Point(64, 172);
            btnStokGiris.Name = "btnStokGiris";
            btnStokGiris.Size = new Size(200, 23);
            btnStokGiris.TabIndex = 8;
            btnStokGiris.Text = "Ekle";
            btnStokGiris.UseVisualStyleBackColor = true;
            btnStokGiris.Click += btnStokGiris_Click;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(64, 70);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(200, 23);
            txtBarkod.TabIndex = 9;
            txtBarkod.TextChanged += txtBarkod_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(270, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(56, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(596, 9);
            label4.Name = "label4";
            label4.Size = new Size(75, 37);
            label4.TabIndex = 11;
            label4.Text = "Ürün";
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(539, 75);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(196, 23);
            txtUrunAd.TabIndex = 12;
            // 
            // txtUrunBarkod
            // 
            txtUrunBarkod.Location = new Point(539, 104);
            txtUrunBarkod.Name = "txtUrunBarkod";
            txtUrunBarkod.Size = new Size(196, 23);
            txtUrunBarkod.TabIndex = 13;
            // 
            // txtUrunRenk
            // 
            txtUrunRenk.Location = new Point(539, 133);
            txtUrunRenk.Name = "txtUrunRenk";
            txtUrunRenk.Size = new Size(196, 23);
            txtUrunRenk.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(478, 78);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 16;
            label6.Text = "Ürün Adı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(478, 107);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 17;
            label7.Text = "Barkod";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(478, 136);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 18;
            label8.Text = "Renk";
            // 
            // labelUrunBulunduBulunamadi
            // 
            labelUrunBulunduBulunamadi.AutoSize = true;
            labelUrunBulunduBulunamadi.Location = new Point(590, 176);
            labelUrunBulunduBulunamadi.Name = "labelUrunBulunduBulunamadi";
            labelUrunBulunduBulunamadi.Size = new Size(0, 15);
            labelUrunBulunduBulunamadi.TabIndex = 19;
            // 
            // pictureBoxGoster
            // 
            pictureBoxGoster.Location = new Point(539, 194);
            pictureBoxGoster.Name = "pictureBoxGoster";
            pictureBoxGoster.Size = new Size(196, 132);
            pictureBoxGoster.TabIndex = 20;
            pictureBoxGoster.TabStop = false;
            pictureBoxGoster.Click += pictureBoxGoster_Click;
            // 
            // StokGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 474);
            Controls.Add(pictureBoxGoster);
            Controls.Add(labelUrunBulunduBulunamadi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtUrunRenk);
            Controls.Add(txtUrunBarkod);
            Controls.Add(txtUrunAd);
            Controls.Add(label4);
            Controls.Add(btnSearch);
            Controls.Add(txtBarkod);
            Controls.Add(btnStokGiris);
            Controls.Add(txtStokSayi);
            Controls.Add(dtpStokTarih);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StokGiris";
            Text = " ";
            Load += StokGiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private DateTimePicker dtpStokTarih;
        private TextBox txtStokSayi;
        private Button btnStokGiris;
        private TextBox txtBarkod;
        private Button btnSearch;
        private Label label4;
        private TextBox txtUrunAd;
        private TextBox txtUrunBarkod;
        private TextBox txtUrunRenk;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelUrunBulunduBulunamadi;
        private PictureBox pictureBoxGoster;
    }
}