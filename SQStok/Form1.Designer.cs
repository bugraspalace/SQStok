namespace SQStok
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            kullaniciAditxt = new TextBox();
            kullaniciSifretxt = new TextBox();
            girisYapbtn = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(30, 281);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(73, 315);
            label2.Name = "label2";
            label2.Size = new Size(42, 19);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // kullaniciAditxt
            // 
            kullaniciAditxt.Location = new Point(127, 278);
            kullaniciAditxt.Name = "kullaniciAditxt";
            kullaniciAditxt.Size = new Size(145, 23);
            kullaniciAditxt.TabIndex = 2;
            // 
            // kullaniciSifretxt
            // 
            kullaniciSifretxt.Location = new Point(127, 312);
            kullaniciSifretxt.Name = "kullaniciSifretxt";
            kullaniciSifretxt.Size = new Size(145, 23);
            kullaniciSifretxt.TabIndex = 3;
            kullaniciSifretxt.TextChanged += kullaniciSifretxt_TextChanged;
            // 
            // girisYapbtn
            // 
            girisYapbtn.Location = new Point(151, 341);
            girisYapbtn.Name = "girisYapbtn";
            girisYapbtn.Size = new Size(75, 23);
            girisYapbtn.TabIndex = 4;
            girisYapbtn.Text = "Giriş";
            girisYapbtn.UseVisualStyleBackColor = true;
            girisYapbtn.Click += girisYapbtn_Click_1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(278, 283);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 15);
            lblUsername.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(278, 320);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 15);
            lblPassword.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(girisYapbtn);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(kullaniciAditxt);
            panel1.Controls.Add(kullaniciSifretxt);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 380);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(364, 376);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SQStok Takip";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox kullaniciAditxt;
        private TextBox kullaniciSifretxt;
        private Button girisYapbtn;
        private Label lblUsername;
        private Label lblPassword;
        private Panel panel1;
    }
}
