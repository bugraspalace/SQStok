namespace SQStok.Tanimlar
{
    partial class MarkaModelTanim
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
            txtMarkaAdi = new TextBox();
            btnMarkaKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtModelAd = new TextBox();
            comboBoxMarkaId = new ComboBox();
            comboBoxKategoriId = new ComboBox();
            checkedListBoxMarkaKategori = new CheckedListBox();
            btnModelKaydet = new Button();
            panel1 = new Panel();
            cmbMarka = new ComboBox();
            panel2 = new Panel();
            radioGuncelleMarka = new RadioButton();
            radioYeniMarka = new RadioButton();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // txtMarkaAdi
            // 
            txtMarkaAdi.Location = new Point(75, 87);
            txtMarkaAdi.Name = "txtMarkaAdi";
            txtMarkaAdi.Size = new Size(152, 23);
            txtMarkaAdi.TabIndex = 0;
            // 
            // btnMarkaKaydet
            // 
            btnMarkaKaydet.Location = new Point(51, 342);
            btnMarkaKaydet.Name = "btnMarkaKaydet";
            btnMarkaKaydet.Size = new Size(152, 23);
            btnMarkaKaydet.TabIndex = 1;
            btnMarkaKaydet.Text = "Kaydet";
            btnMarkaKaydet.UseVisualStyleBackColor = true;
            btnMarkaKaydet.Click += btnMarkaKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 101);
            label1.Name = "label1";
            label1.Size = new Size(40, 30);
            label1.TabIndex = 3;
            label1.Text = "Marka\r\nAdı:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 219);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 4;
            label2.Text = "Marka\r\nKategorisi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 8);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "Marka Tanım";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 15);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 6;
            label4.Text = "Model Tanım";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 87);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 7;
            label5.Text = "Model Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 142);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 8;
            label6.Text = "Marka Seçim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 113);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 9;
            label7.Text = "Kategori Seçim";
            // 
            // txtModelAd
            // 
            txtModelAd.Location = new Point(94, 79);
            txtModelAd.Name = "txtModelAd";
            txtModelAd.Size = new Size(152, 23);
            txtModelAd.TabIndex = 10;
            // 
            // comboBoxMarkaId
            // 
            comboBoxMarkaId.FormattingEnabled = true;
            comboBoxMarkaId.Location = new Point(94, 139);
            comboBoxMarkaId.Name = "comboBoxMarkaId";
            comboBoxMarkaId.Size = new Size(152, 23);
            comboBoxMarkaId.TabIndex = 11;
            // 
            // comboBoxKategoriId
            // 
            comboBoxKategoriId.FormattingEnabled = true;
            comboBoxKategoriId.Location = new Point(94, 110);
            comboBoxKategoriId.Name = "comboBoxKategoriId";
            comboBoxKategoriId.Size = new Size(152, 23);
            comboBoxKategoriId.TabIndex = 12;
            // 
            // checkedListBoxMarkaKategori
            // 
            checkedListBoxMarkaKategori.FormattingEnabled = true;
            checkedListBoxMarkaKategori.Location = new Point(75, 220);
            checkedListBoxMarkaKategori.Name = "checkedListBoxMarkaKategori";
            checkedListBoxMarkaKategori.Size = new Size(152, 94);
            checkedListBoxMarkaKategori.TabIndex = 14;
            // 
            // btnModelKaydet
            // 
            btnModelKaydet.Location = new Point(70, 342);
            btnModelKaydet.Name = "btnModelKaydet";
            btnModelKaydet.Size = new Size(152, 23);
            btnModelKaydet.TabIndex = 15;
            btnModelKaydet.Text = "Kaydet";
            btnModelKaydet.UseVisualStyleBackColor = true;
            btnModelKaydet.Click += btnModelKaydet_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cmbMarka);
            panel1.Controls.Add(btnMarkaKaydet);
            panel1.Controls.Add(txtMarkaAdi);
            panel1.Controls.Add(checkedListBoxMarkaKategori);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 372);
            panel1.TabIndex = 16;
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(75, 116);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(152, 23);
            cmbMarka.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(radioGuncelleMarka);
            panel2.Controls.Add(radioYeniMarka);
            panel2.Location = new Point(12, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 50);
            panel2.TabIndex = 17;
            // 
            // radioGuncelleMarka
            // 
            radioGuncelleMarka.AutoSize = true;
            radioGuncelleMarka.Location = new Point(130, 28);
            radioGuncelleMarka.Name = "radioGuncelleMarka";
            radioGuncelleMarka.Size = new Size(107, 19);
            radioGuncelleMarka.TabIndex = 1;
            radioGuncelleMarka.TabStop = true;
            radioGuncelleMarka.Text = "Marka Güncelle";
            radioGuncelleMarka.UseVisualStyleBackColor = true;
            // 
            // radioYeniMarka
            // 
            radioYeniMarka.AutoSize = true;
            radioYeniMarka.Location = new Point(3, 27);
            radioYeniMarka.Name = "radioYeniMarka";
            radioYeniMarka.Size = new Size(83, 19);
            radioYeniMarka.TabIndex = 0;
            radioYeniMarka.TabStop = true;
            radioYeniMarka.Text = "Yeni Marka";
            radioYeniMarka.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnModelKaydet);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(comboBoxKategoriId);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(comboBoxMarkaId);
            panel3.Controls.Add(txtModelAd);
            panel3.Location = new Point(490, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 372);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(490, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 50);
            panel4.TabIndex = 19;
            // 
            // MarkaModelTanim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 396);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MarkaModelTanim";
            Text = "MarkaModelTanim";
            Load += MarkaModelTanim_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMarkaAdi;
        private Button btnMarkaKaydet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtModelAd;
        private ComboBox comboBoxMarkaId;
        private ComboBox comboBoxKategoriId;
        private CheckedListBox checkedListBoxMarkaKategori;
        private Button btnModelKaydet;
        private Panel panel1;
        private Panel panel2;
        private RadioButton radioYeniMarka;
        private RadioButton radioGuncelleMarka;
        private ComboBox cmbMarka;
        private Panel panel3;
        private Panel panel4;
    }
}