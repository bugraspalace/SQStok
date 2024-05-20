namespace SQStok.Stok
{
    partial class UrunTanim
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
            label12 = new Label();
            txtStok = new TextBox();
            txtAgirlik = new TextBox();
            txtMinStok = new TextBox();
            txtBarkod = new TextBox();
            txtUrunAd = new TextBox();
            comboBoxModel = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            comboBoxMarka = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            richTxtAciklama = new RichTextBox();
            txtRenk = new TextBox();
            label9 = new Label();
            label13 = new Label();
            txtMaaliyet = new TextBox();
            txtKDVoran = new TextBox();
            btnEkleUrun = new Button();
            comboBoxKategori = new ComboBox();
            btnResimEkle = new Button();
            pictureBoxResim = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResim).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(112, 9);
            label12.Name = "label12";
            label12.Size = new Size(193, 39);
            label12.TabIndex = 49;
            label12.Text = "ÜRÜN TANIM";
            // 
            // txtStok
            // 
            txtStok.Location = new Point(124, 423);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(181, 23);
            txtStok.TabIndex = 47;
            // 
            // txtAgirlik
            // 
            txtAgirlik.Location = new Point(124, 394);
            txtAgirlik.Name = "txtAgirlik";
            txtAgirlik.Size = new Size(181, 23);
            txtAgirlik.TabIndex = 46;
            // 
            // txtMinStok
            // 
            txtMinStok.Location = new Point(124, 452);
            txtMinStok.Name = "txtMinStok";
            txtMinStok.Size = new Size(181, 23);
            txtMinStok.TabIndex = 45;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(124, 112);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(181, 23);
            txtBarkod.TabIndex = 42;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(124, 83);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(181, 23);
            txtUrunAd.TabIndex = 41;
            // 
            // comboBoxModel
            // 
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(124, 307);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(181, 23);
            comboBoxModel.TabIndex = 40;
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 368);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 39;
            label11.Text = "KDV Oran :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(48, 310);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 38;
            label10.Text = "Model :";
            // 
            // comboBoxMarka
            // 
            comboBoxMarka.FormattingEnabled = true;
            comboBoxMarka.Location = new Point(124, 278);
            comboBoxMarka.Name = "comboBoxMarka";
            comboBoxMarka.Size = new Size(181, 23);
            comboBoxMarka.TabIndex = 37;
            comboBoxMarka.SelectedIndexChanged += comboBoxMarka_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 426);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 33;
            label8.Text = "Stok :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 397);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 32;
            label7.Text = "Ağırlığı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 278);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 31;
            label6.Text = "Marka :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 252);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 30;
            label5.Text = "Renk :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 223);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 29;
            label4.Text = "Kategori Id :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 153);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 28;
            label3.Text = "Ürün Açıklama :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 115);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 27;
            label2.Text = "Barkod :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 86);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 26;
            label1.Text = "Ad :";
            // 
            // richTxtAciklama
            // 
            richTxtAciklama.Location = new Point(124, 141);
            richTxtAciklama.Name = "richTxtAciklama";
            richTxtAciklama.Size = new Size(181, 73);
            richTxtAciklama.TabIndex = 51;
            richTxtAciklama.Text = "";
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(124, 249);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(181, 23);
            txtRenk.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 455);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 53;
            label9.Text = "Min Stok :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 339);
            label13.Name = "label13";
            label13.Size = new Size(58, 15);
            label13.TabIndex = 54;
            label13.Text = "Maaliyet :";
            // 
            // txtMaaliyet
            // 
            txtMaaliyet.Location = new Point(124, 336);
            txtMaaliyet.Name = "txtMaaliyet";
            txtMaaliyet.Size = new Size(181, 23);
            txtMaaliyet.TabIndex = 55;
            // 
            // txtKDVoran
            // 
            txtKDVoran.Location = new Point(124, 365);
            txtKDVoran.Name = "txtKDVoran";
            txtKDVoran.Size = new Size(181, 23);
            txtKDVoran.TabIndex = 56;
            // 
            // btnEkleUrun
            // 
            btnEkleUrun.Location = new Point(124, 551);
            btnEkleUrun.Name = "btnEkleUrun";
            btnEkleUrun.Size = new Size(181, 55);
            btnEkleUrun.TabIndex = 57;
            btnEkleUrun.Text = "Ekle";
            btnEkleUrun.UseVisualStyleBackColor = true;
            btnEkleUrun.Click += btnEkleUrun_Click;
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Location = new Point(124, 220);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(181, 23);
            comboBoxKategori.TabIndex = 58;
            comboBoxKategori.SelectedIndexChanged += comboBoxKategori_SelectedIndexChanged;
            // 
            // btnResimEkle
            // 
            btnResimEkle.Location = new Point(124, 494);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(181, 38);
            btnResimEkle.TabIndex = 59;
            btnResimEkle.Text = "Resim Ekle";
            btnResimEkle.UseVisualStyleBackColor = true;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // pictureBoxResim
            // 
            pictureBoxResim.Location = new Point(311, 423);
            pictureBoxResim.Name = "pictureBoxResim";
            pictureBoxResim.Size = new Size(148, 106);
            pictureBoxResim.TabIndex = 60;
            pictureBoxResim.TabStop = false;
            // 
            // UrunTanim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 694);
            Controls.Add(pictureBoxResim);
            Controls.Add(btnResimEkle);
            Controls.Add(comboBoxKategori);
            Controls.Add(btnEkleUrun);
            Controls.Add(txtKDVoran);
            Controls.Add(txtMaaliyet);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(richTxtAciklama);
            Controls.Add(label12);
            Controls.Add(txtStok);
            Controls.Add(txtAgirlik);
            Controls.Add(txtMinStok);
            Controls.Add(txtRenk);
            Controls.Add(txtBarkod);
            Controls.Add(txtUrunAd);
            Controls.Add(comboBoxModel);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBoxMarka);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunTanim";
            Text = "UrunTanim";
            Load += UrunTanim_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private TextBox txtStok;
        private TextBox txtAgirlik;
        private TextBox txtMinStok;
        private TextBox txtBarkod;
        private TextBox txtUrunAd;
        private ComboBox comboBoxModel;
        private Label label11;
        private Label label10;
        private ComboBox comboBoxMarka;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox richTxtAciklama;
        private TextBox txtRenk;
        private Label label9;
        private Label label13;
        private TextBox txtMaaliyet;
        private TextBox txtKDVoran;
        private Button btnEkleUrun;
        private ComboBox comboBoxKategori;
        private Button btnResimEkle;
        private PictureBox pictureBoxResim;
    }
}