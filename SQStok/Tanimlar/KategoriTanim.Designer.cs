namespace SQStok.Stok
{
    partial class KategoriTanim
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
            richTxtAciklama = new RichTextBox();
            label12 = new Label();
            txtKategoriAd = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnKategoriEkle = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTxtAciklama
            // 
            richTxtAciklama.Location = new Point(106, 116);
            richTxtAciklama.Name = "richTxtAciklama";
            richTxtAciklama.Size = new Size(181, 73);
            richTxtAciklama.TabIndex = 58;
            richTxtAciklama.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(71, 24);
            label12.Name = "label12";
            label12.Size = new Size(245, 39);
            label12.TabIndex = 57;
            label12.Text = "KATEGORİ TANIM";
            label12.Click += label12_Click;
            // 
            // txtKategoriAd
            // 
            txtKategoriAd.Location = new Point(106, 87);
            txtKategoriAd.Name = "txtKategoriAd";
            txtKategoriAd.Size = new Size(181, 23);
            txtKategoriAd.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 128);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 54;
            label3.Text = "Ürün \r\nAçıklama :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 90);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 52;
            label1.Text = "Ad :";
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(106, 195);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(181, 48);
            btnKategoriEkle.TabIndex = 59;
            btnKategoriEkle.Text = "Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnKategoriEkle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(richTxtAciklama);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtKategoriAd);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 468);
            panel1.TabIndex = 60;
            // 
            // KategoriTanim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 468);
            Controls.Add(panel1);
            Name = "KategoriTanim";
            Text = "KategoriTanim";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTxtAciklama;
        private Label label12;
        private TextBox txtKategoriAd;
        private Label label3;
        private Label label1;
        private Button btnKategoriEkle;
        private Panel panel1;
    }
}