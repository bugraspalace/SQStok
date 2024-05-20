namespace SQStok.Personel_Yönetim
{
    partial class PersonelEkle
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            radioKadin = new RadioButton();
            radioErkek = new RadioButton();
            label9 = new Label();
            birimCombobox = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            pozisyonCombobox = new ComboBox();
            personelAdtxt = new TextBox();
            personelSoyadtxt = new TextBox();
            tcNotxt = new TextBox();
            telefonNotxt = new TextBox();
            ePostatxt = new TextBox();
            personeKullaniciAdtxt = new TextBox();
            personelSifretxt = new TextBox();
            personelGuncellebtn = new Button();
            label12 = new Label();
            dateDogumTarih = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 110);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 148);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 186);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Doğum Tarihi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 224);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "T.C. No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 262);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefon :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 300);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 5;
            label6.Text = "E-Posta :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 452);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 6;
            label7.Text = "Kullanıcı Adı :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(98, 490);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 7;
            label8.Text = "Şifre :";
            // 
            // radioKadin
            // 
            radioKadin.AutoSize = true;
            radioKadin.Location = new Point(161, 335);
            radioKadin.Name = "radioKadin";
            radioKadin.Size = new Size(55, 19);
            radioKadin.TabIndex = 8;
            radioKadin.TabStop = true;
            radioKadin.Text = "Kadın";
            radioKadin.UseVisualStyleBackColor = true;
            // 
            // radioErkek
            // 
            radioErkek.AutoSize = true;
            radioErkek.Location = new Point(232, 335);
            radioErkek.Name = "radioErkek";
            radioErkek.Size = new Size(53, 19);
            radioErkek.TabIndex = 9;
            radioErkek.TabStop = true;
            radioErkek.Text = "Erkek";
            radioErkek.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(79, 338);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 10;
            label9.Text = "Cinsiyet :";
            // 
            // birimCombobox
            // 
            birimCombobox.FormattingEnabled = true;
            birimCombobox.Location = new Point(161, 368);
            birimCombobox.Name = "birimCombobox";
            birimCombobox.Size = new Size(181, 23);
            birimCombobox.TabIndex = 11;
            birimCombobox.SelectedIndexChanged += birimCombobox_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(93, 376);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 12;
            label10.Text = "Birim :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(74, 414);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 13;
            label11.Text = "Pozisyon :";
            // 
            // pozisyonCombobox
            // 
            pozisyonCombobox.FormattingEnabled = true;
            pozisyonCombobox.Location = new Point(161, 406);
            pozisyonCombobox.Name = "pozisyonCombobox";
            pozisyonCombobox.Size = new Size(181, 23);
            pozisyonCombobox.TabIndex = 14;
            pozisyonCombobox.SelectedIndexChanged += pozisyonCombobox_SelectedIndexChanged;
            // 
            // personelAdtxt
            // 
            personelAdtxt.Location = new Point(161, 107);
            personelAdtxt.Name = "personelAdtxt";
            personelAdtxt.Size = new Size(181, 23);
            personelAdtxt.TabIndex = 15;
            // 
            // personelSoyadtxt
            // 
            personelSoyadtxt.Location = new Point(161, 140);
            personelSoyadtxt.Name = "personelSoyadtxt";
            personelSoyadtxt.Size = new Size(181, 23);
            personelSoyadtxt.TabIndex = 16;
            // 
            // tcNotxt
            // 
            tcNotxt.Location = new Point(161, 216);
            tcNotxt.Name = "tcNotxt";
            tcNotxt.Size = new Size(181, 23);
            tcNotxt.TabIndex = 18;
            // 
            // telefonNotxt
            // 
            telefonNotxt.Location = new Point(161, 254);
            telefonNotxt.Name = "telefonNotxt";
            telefonNotxt.Size = new Size(181, 23);
            telefonNotxt.TabIndex = 19;
            // 
            // ePostatxt
            // 
            ePostatxt.Location = new Point(161, 292);
            ePostatxt.Name = "ePostatxt";
            ePostatxt.Size = new Size(181, 23);
            ePostatxt.TabIndex = 20;
            // 
            // personeKullaniciAdtxt
            // 
            personeKullaniciAdtxt.Location = new Point(161, 452);
            personeKullaniciAdtxt.Name = "personeKullaniciAdtxt";
            personeKullaniciAdtxt.Size = new Size(181, 23);
            personeKullaniciAdtxt.TabIndex = 21;
            // 
            // personelSifretxt
            // 
            personelSifretxt.Location = new Point(161, 490);
            personelSifretxt.Name = "personelSifretxt";
            personelSifretxt.Size = new Size(181, 23);
            personelSifretxt.TabIndex = 22;
            // 
            // personelGuncellebtn
            // 
            personelGuncellebtn.AutoSize = true;
            personelGuncellebtn.BackColor = Color.Lime;
            personelGuncellebtn.Location = new Point(161, 538);
            personelGuncellebtn.Name = "personelGuncellebtn";
            personelGuncellebtn.Size = new Size(181, 25);
            personelGuncellebtn.TabIndex = 23;
            personelGuncellebtn.Text = "Ekle";
            personelGuncellebtn.UseVisualStyleBackColor = false;
            personelGuncellebtn.Click += personelEklebtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(432, 26);
            label12.Name = "label12";
            label12.Size = new Size(222, 39);
            label12.TabIndex = 24;
            label12.Text = "PERSONEL EKLE";
            // 
            // dateDogumTarih
            // 
            dateDogumTarih.Location = new Point(161, 180);
            dateDogumTarih.Name = "dateDogumTarih";
            dateDogumTarih.Size = new Size(181, 23);
            dateDogumTarih.TabIndex = 25;
            // 
            // PersonelEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1107, 582);
            Controls.Add(dateDogumTarih);
            Controls.Add(label12);
            Controls.Add(personelGuncellebtn);
            Controls.Add(personelSifretxt);
            Controls.Add(personeKullaniciAdtxt);
            Controls.Add(ePostatxt);
            Controls.Add(telefonNotxt);
            Controls.Add(tcNotxt);
            Controls.Add(personelSoyadtxt);
            Controls.Add(personelAdtxt);
            Controls.Add(pozisyonCombobox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(birimCombobox);
            Controls.Add(label9);
            Controls.Add(radioErkek);
            Controls.Add(radioKadin);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonelEkle";
            Text = "PersonelEkle";
            Load += PersonelEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RadioButton radioKadin;
        private RadioButton radioErkek;
        private Label label9;
        private ComboBox birimCombobox;
        private Label label10;
        private Label label11;
        private ComboBox pozisyonCombobox;
        private TextBox personelAdtxt;
        private TextBox personelSoyadtxt;
        private TextBox tcNotxt;
        private TextBox telefonNotxt;
        private TextBox ePostatxt;
        private TextBox personeKullaniciAdtxt;
        private TextBox personelSifretxt;
        private Button personelGuncellebtn;
        private Label label12;
        private DateTimePicker dateDogumTarih;
    }
}