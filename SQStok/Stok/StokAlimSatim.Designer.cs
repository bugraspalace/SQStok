namespace SQStok.Stok
{
    partial class StokAlimSatim
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
            radioGunluk = new RadioButton();
            label1 = new Label();
            panelFiltre = new Panel();
            radiOzel = new RadioButton();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cmbModel = new ComboBox();
            cmbMarka = new ComboBox();
            cmbKategori = new ComboBox();
            btnAra = new Button();
            label4 = new Label();
            label3 = new Label();
            dtpBitisTarih = new DateTimePicker();
            label2 = new Label();
            dtpBaslangicTarih = new DateTimePicker();
            radioAylik = new RadioButton();
            radioHaftalik = new RadioButton();
            dgwListe = new DataGridView();
            label5 = new Label();
            panelFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwListe).BeginInit();
            SuspendLayout();
            // 
            // radioGunluk
            // 
            radioGunluk.AutoSize = true;
            radioGunluk.Location = new Point(3, 18);
            radioGunluk.Name = "radioGunluk";
            radioGunluk.Size = new Size(63, 19);
            radioGunluk.TabIndex = 0;
            radioGunluk.TabStop = true;
            radioGunluk.Text = "Günlük";
            radioGunluk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Filtrele";
            // 
            // panelFiltre
            // 
            panelFiltre.BorderStyle = BorderStyle.FixedSingle;
            panelFiltre.Controls.Add(radiOzel);
            panelFiltre.Controls.Add(label8);
            panelFiltre.Controls.Add(label7);
            panelFiltre.Controls.Add(label6);
            panelFiltre.Controls.Add(cmbModel);
            panelFiltre.Controls.Add(cmbMarka);
            panelFiltre.Controls.Add(cmbKategori);
            panelFiltre.Controls.Add(btnAra);
            panelFiltre.Controls.Add(label4);
            panelFiltre.Controls.Add(label3);
            panelFiltre.Controls.Add(dtpBitisTarih);
            panelFiltre.Controls.Add(label2);
            panelFiltre.Controls.Add(dtpBaslangicTarih);
            panelFiltre.Controls.Add(radioAylik);
            panelFiltre.Controls.Add(radioHaftalik);
            panelFiltre.Controls.Add(radioGunluk);
            panelFiltre.Controls.Add(label1);
            panelFiltre.Location = new Point(4, 27);
            panelFiltre.Name = "panelFiltre";
            panelFiltre.Size = new Size(272, 411);
            panelFiltre.TabIndex = 2;
            panelFiltre.Paint += panelFiltre_Paint;
            // 
            // radiOzel
            // 
            radiOzel.AutoSize = true;
            radiOzel.Location = new Point(201, 18);
            radiOzel.Name = "radiOzel";
            radiOzel.Size = new Size(48, 19);
            radiOzel.TabIndex = 16;
            radiOzel.TabStop = true;
            radiOzel.Text = "Özel";
            radiOzel.UseVisualStyleBackColor = true;
            radiOzel.CheckedChanged += radiOzel_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 258);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 15;
            label8.Text = "Model Seç";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 200);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 14;
            label7.Text = "Kategori Seç";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 229);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 13;
            label6.Text = "Marka Seç";
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(97, 255);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(160, 23);
            cmbModel.TabIndex = 12;
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(97, 226);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(160, 23);
            cmbMarka.TabIndex = 11;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(97, 197);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(160, 23);
            cmbKategori.TabIndex = 10;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(3, 377);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(264, 33);
            btnAra.TabIndex = 9;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 73);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "Tarih Seç";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 134);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Bitiş Tarihi";
            // 
            // dtpBitisTarih
            // 
            dtpBitisTarih.Location = new Point(99, 128);
            dtpBitisTarih.Name = "dtpBitisTarih";
            dtpBitisTarih.Size = new Size(164, 23);
            dtpBitisTarih.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 105);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 5;
            label2.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangicTarih
            // 
            dtpBaslangicTarih.Location = new Point(99, 99);
            dtpBaslangicTarih.Name = "dtpBaslangicTarih";
            dtpBaslangicTarih.Size = new Size(164, 23);
            dtpBaslangicTarih.TabIndex = 4;
            // 
            // radioAylik
            // 
            radioAylik.AutoSize = true;
            radioAylik.Location = new Point(144, 18);
            radioAylik.Name = "radioAylik";
            radioAylik.Size = new Size(51, 19);
            radioAylik.TabIndex = 3;
            radioAylik.TabStop = true;
            radioAylik.Text = "Aylık";
            radioAylik.UseVisualStyleBackColor = true;
            // 
            // radioHaftalik
            // 
            radioHaftalik.AutoSize = true;
            radioHaftalik.Location = new Point(72, 18);
            radioHaftalik.Name = "radioHaftalik";
            radioHaftalik.Size = new Size(66, 19);
            radioHaftalik.TabIndex = 2;
            radioHaftalik.TabStop = true;
            radioHaftalik.Text = "Haftalık";
            radioHaftalik.UseVisualStyleBackColor = true;
            radioHaftalik.CheckedChanged += radioHaftalik_CheckedChanged;
            // 
            // dgwListe
            // 
            dgwListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwListe.Dock = DockStyle.Right;
            dgwListe.Location = new Point(278, 0);
            dgwListe.Name = "dgwListe";
            dgwListe.Size = new Size(522, 450);
            dgwListe.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 9);
            label5.Name = "label5";
            label5.Size = new Size(136, 15);
            label5.TabIndex = 4;
            label5.Text = "Stok Alım Satım Geçmişi";
            // 
            // StokAlimSatim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(dgwListe);
            Controls.Add(panelFiltre);
            Name = "StokAlimSatim";
            Text = "StokAlimSatim";
            Load += StokAlimSatim_Load;
            panelFiltre.ResumeLayout(false);
            panelFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioGunluk;
        private Label label1;
        private Panel panelFiltre;
        private RadioButton radioAylik;
        private RadioButton radioHaftalik;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpBitisTarih;
        private Label label2;
        private DateTimePicker dtpBaslangicTarih;
        private Button btnAra;
        private DataGridView dgwListe;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cmbModel;
        private ComboBox cmbMarka;
        private ComboBox cmbKategori;
        private RadioButton radiOzel;
    }
}