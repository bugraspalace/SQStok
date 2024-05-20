namespace SQStok
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            menuStrip1 = new MenuStrip();
            personelYonetimMenu = new ToolStripMenuItem();
            personellerToolStripMenuItem = new ToolStripMenuItem();
            personelEkleToolStripMenuItem = new ToolStripMenuItem();
            personelSilGüncelleToolStripMenuItem = new ToolStripMenuItem();
            birimPozisyonTanımToolStripMenuItem = new ToolStripMenuItem();
            stokYonetimMenu = new ToolStripMenuItem();
            satınAlımİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            satışİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            stokHareketleriToolStripMenuItem = new ToolStripMenuItem();
            envanterToolStripMenuItem = new ToolStripMenuItem();
            tanimlarToolStripMenuItem = new ToolStripMenuItem();
            kategoriUrunTanimToolStripMenuItem = new ToolStripMenuItem();
            kategoriTanimToolStripMenuItem = new ToolStripMenuItem();
            urunTanimToolStripMenuItem = new ToolStripMenuItem();
            markaModelTanimToolStripMenuItem = new ToolStripMenuItem();
            birimPozisyonTanimToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelAktifKullanici = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { personelYonetimMenu, stokYonetimMenu, tanimlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(972, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // personelYonetimMenu
            // 
            personelYonetimMenu.DropDownItems.AddRange(new ToolStripItem[] { personellerToolStripMenuItem, personelEkleToolStripMenuItem, personelSilGüncelleToolStripMenuItem, birimPozisyonTanımToolStripMenuItem });
            personelYonetimMenu.Name = "personelYonetimMenu";
            personelYonetimMenu.Size = new Size(111, 20);
            personelYonetimMenu.Text = "Personel Yönetim";
            // 
            // personellerToolStripMenuItem
            // 
            personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            personellerToolStripMenuItem.Size = new Size(189, 22);
            personellerToolStripMenuItem.Text = "Personeller";
            personellerToolStripMenuItem.Click += personellerToolStripMenuItem_Click;
            // 
            // personelEkleToolStripMenuItem
            // 
            personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            personelEkleToolStripMenuItem.Size = new Size(189, 22);
            personelEkleToolStripMenuItem.Text = "Personel Ekle";
            personelEkleToolStripMenuItem.Click += personelEkleToolStripMenuItem_Click;
            // 
            // personelSilGüncelleToolStripMenuItem
            // 
            personelSilGüncelleToolStripMenuItem.Name = "personelSilGüncelleToolStripMenuItem";
            personelSilGüncelleToolStripMenuItem.Size = new Size(189, 22);
            personelSilGüncelleToolStripMenuItem.Text = "Personel Sil/Güncelle";
            personelSilGüncelleToolStripMenuItem.Click += personelSilGüncelleToolStripMenuItem_Click;
            // 
            // birimPozisyonTanımToolStripMenuItem
            // 
            birimPozisyonTanımToolStripMenuItem.Name = "birimPozisyonTanımToolStripMenuItem";
            birimPozisyonTanımToolStripMenuItem.Size = new Size(189, 22);
            birimPozisyonTanımToolStripMenuItem.Text = "Birim/Pozisyon Tanım";
            birimPozisyonTanımToolStripMenuItem.Click += birimPozisyonTanımToolStripMenuItem_Click;
            // 
            // stokYonetimMenu
            // 
            stokYonetimMenu.DropDownItems.AddRange(new ToolStripItem[] { satınAlımİşlemleriToolStripMenuItem, satışİşlemleriToolStripMenuItem, stokHareketleriToolStripMenuItem, envanterToolStripMenuItem });
            stokYonetimMenu.Name = "stokYonetimMenu";
            stokYonetimMenu.Size = new Size(89, 20);
            stokYonetimMenu.Text = "Stok Yönetim";
            // 
            // satınAlımİşlemleriToolStripMenuItem
            // 
            satınAlımİşlemleriToolStripMenuItem.Name = "satınAlımİşlemleriToolStripMenuItem";
            satınAlımİşlemleriToolStripMenuItem.Size = new Size(175, 22);
            satınAlımİşlemleriToolStripMenuItem.Text = "Satın Alım İşlemleri";
            satınAlımİşlemleriToolStripMenuItem.Click += satınAlımİşlemleriToolStripMenuItem_Click;
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            satışİşlemleriToolStripMenuItem.Size = new Size(175, 22);
            satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            satışİşlemleriToolStripMenuItem.Click += satışİşlemleriToolStripMenuItem_Click;
            // 
            // stokHareketleriToolStripMenuItem
            // 
            stokHareketleriToolStripMenuItem.Name = "stokHareketleriToolStripMenuItem";
            stokHareketleriToolStripMenuItem.Size = new Size(175, 22);
            stokHareketleriToolStripMenuItem.Text = "Stok Hareketleri";
            stokHareketleriToolStripMenuItem.Click += stokHareketleriToolStripMenuItem_Click;
            // 
            // envanterToolStripMenuItem
            // 
            envanterToolStripMenuItem.Name = "envanterToolStripMenuItem";
            envanterToolStripMenuItem.Size = new Size(175, 22);
            envanterToolStripMenuItem.Text = "Envanter Takip";
            // 
            // tanimlarToolStripMenuItem
            // 
            tanimlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kategoriUrunTanimToolStripMenuItem, markaModelTanimToolStripMenuItem, birimPozisyonTanimToolStripMenuItem });
            tanimlarToolStripMenuItem.Name = "tanimlarToolStripMenuItem";
            tanimlarToolStripMenuItem.Size = new Size(64, 20);
            tanimlarToolStripMenuItem.Text = "Tanımlar";
            //tanimlarToolStripMenuItem.Click += tanimlarToolStripMenuItem_Click;
            // 
            // kategoriUrunTanimToolStripMenuItem
            // 
            kategoriUrunTanimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kategoriTanimToolStripMenuItem, urunTanimToolStripMenuItem });
            kategoriUrunTanimToolStripMenuItem.Name = "kategoriUrunTanimToolStripMenuItem";
            kategoriUrunTanimToolStripMenuItem.Size = new Size(189, 22);
            kategoriUrunTanimToolStripMenuItem.Text = "Kategori/Ürün Tanım";
            // 
            // kategoriTanimToolStripMenuItem
            // 
            kategoriTanimToolStripMenuItem.Name = "kategoriTanimToolStripMenuItem";
            kategoriTanimToolStripMenuItem.Size = new Size(153, 22);
            kategoriTanimToolStripMenuItem.Text = "Kategori Tanim";
            kategoriTanimToolStripMenuItem.Click += kategoriTanimToolStripMenuItem_Click;
            // 
            // urunTanimToolStripMenuItem
            // 
            urunTanimToolStripMenuItem.Name = "urunTanimToolStripMenuItem";
            urunTanimToolStripMenuItem.Size = new Size(153, 22);
            urunTanimToolStripMenuItem.Text = "Urun Tanim";
            urunTanimToolStripMenuItem.Click += urunTanimToolStripMenuItem_Click_1;
            // 
            // markaModelTanimToolStripMenuItem
            // 
            markaModelTanimToolStripMenuItem.Name = "markaModelTanimToolStripMenuItem";
            markaModelTanimToolStripMenuItem.Size = new Size(189, 22);
            markaModelTanimToolStripMenuItem.Text = "Marka/Model Tanim";
            markaModelTanimToolStripMenuItem.Click += markaModelTanimToolStripMenuItem_Click;
            // 
            // birimPozisyonTanimToolStripMenuItem
            // 
            birimPozisyonTanimToolStripMenuItem.Name = "birimPozisyonTanimToolStripMenuItem";
            birimPozisyonTanimToolStripMenuItem.Size = new Size(189, 22);
            birimPozisyonTanimToolStripMenuItem.Text = "Birim/Pozisyon Tanim";
            //birimPozisyonTanimToolStripMenuItem.Click += birimPozisyonTanimToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelAktifKullanici });
            statusStrip1.Location = new Point(0, 485);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(972, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelAktifKullanici
            // 
            toolStripStatusLabelAktifKullanici.Name = "toolStripStatusLabelAktifKullanici";
            toolStripStatusLabelAktifKullanici.Size = new Size(86, 17);
            toolStripStatusLabelAktifKullanici.Text = "Aktif Kullanıcı :";
            //toolStripStatusLabelAktifKullanici.Click += toolStripStatusLabelAktifKullanici_Click;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 507);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaSayfa";
            FormClosing += AnaSayfa_FormClosing;
            Load += AnaSayfa_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem personelYonetimMenu;
        private ToolStripMenuItem stokYonetimMenu;
        private ToolStripMenuItem personellerToolStripMenuItem;
        private ToolStripMenuItem personelEkleToolStripMenuItem;
        private ToolStripMenuItem personelSilGüncelleToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelAktifKullanici;
        private ToolStripMenuItem satınAlımİşlemleriToolStripMenuItem;
        private ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private ToolStripMenuItem tanimlarToolStripMenuItem;
        private ToolStripMenuItem kategoriUrunTanimToolStripMenuItem;
        private ToolStripMenuItem kategoriTanimToolStripMenuItem;
        private ToolStripMenuItem urunTanimToolStripMenuItem;
        private ToolStripMenuItem markaModelTanimToolStripMenuItem;
        private ToolStripMenuItem birimPozisyonTanimToolStripMenuItem;
        private ToolStripMenuItem stokHareketleriToolStripMenuItem;
        private ToolStripMenuItem envanterToolStripMenuItem;
        private ToolStripMenuItem birimPozisyonTanımToolStripMenuItem;
    }
}