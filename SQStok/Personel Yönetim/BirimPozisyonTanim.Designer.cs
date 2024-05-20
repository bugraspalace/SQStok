namespace SQStok.Personel_Yönetim
{
    partial class BirimPozisyonTanim
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
            txtBirim = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnBirimKaydet = new Button();
            txtPozisyon = new TextBox();
            cmbBirim = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnPozisyonKaydet = new Button();
            SuspendLayout();
            // 
            // txtBirim
            // 
            txtBirim.Location = new Point(80, 66);
            txtBirim.Name = "txtBirim";
            txtBirim.Size = new Size(165, 23);
            txtBirim.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Birim Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 23);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Birim Tanım";
            // 
            // btnBirimKaydet
            // 
            btnBirimKaydet.Location = new Point(122, 133);
            btnBirimKaydet.Name = "btnBirimKaydet";
            btnBirimKaydet.Size = new Size(75, 23);
            btnBirimKaydet.TabIndex = 3;
            btnBirimKaydet.Text = "Kaydet";
            btnBirimKaydet.UseVisualStyleBackColor = true;
            btnBirimKaydet.Click += btnBirimKaydet_Click;
            // 
            // txtPozisyon
            // 
            txtPozisyon.Location = new Point(538, 66);
            txtPozisyon.Name = "txtPozisyon";
            txtPozisyon.Size = new Size(165, 23);
            txtPozisyon.TabIndex = 4;
            // 
            // cmbBirim
            // 
            cmbBirim.FormattingEnabled = true;
            cmbBirim.Location = new Point(538, 95);
            cmbBirim.Name = "cmbBirim";
            cmbBirim.Size = new Size(165, 23);
            cmbBirim.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(581, 23);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 6;
            label3.Text = "Pozisyon Tanım";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 69);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 7;
            label4.Text = "Pozisyon Adı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(419, 98);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 8;
            label5.Text = "Bağlı Olduğu Birim :";
            // 
            // btnPozisyonKaydet
            // 
            btnPozisyonKaydet.Location = new Point(581, 133);
            btnPozisyonKaydet.Name = "btnPozisyonKaydet";
            btnPozisyonKaydet.Size = new Size(75, 23);
            btnPozisyonKaydet.TabIndex = 9;
            btnPozisyonKaydet.Text = "Kaydet";
            btnPozisyonKaydet.UseVisualStyleBackColor = true;
            btnPozisyonKaydet.Click += btnPozisyonKaydet_Click;
            // 
            // BirimPozisyonTanim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPozisyonKaydet);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbBirim);
            Controls.Add(txtPozisyon);
            Controls.Add(btnBirimKaydet);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBirim);
            Name = "BirimPozisyonTanim";
            Text = "BirimPozisyonTanim";
            Load += BirimPozisyonTanim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBirim;
        private Label label1;
        private Label label2;
        private Button btnBirimKaydet;
        private TextBox txtPozisyon;
        private ComboBox cmbBirim;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnPozisyonKaydet;
    }
}