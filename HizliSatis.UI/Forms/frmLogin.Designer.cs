namespace HizliSatis.UI.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            txtSifre = new DevExpress.XtraEditors.TextEdit();
            chkbtnBeniHatirla = new DevExpress.XtraEditors.CheckButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 28);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(153, 43);
            label1.Name = "label1";
            label1.Size = new Size(280, 39);
            label1.TabIndex = 1;
            label1.Text = "Cosmos Sales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(281, 82);
            label3.Name = "label3";
            label3.Size = new Size(170, 27);
            label3.TabIndex = 3;
            label3.Text = "Hızlı Satış Sistemi";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(235, 116);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(139, 28);
            txtKullaniciAdi.TabIndex = 10;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(235, 150);
            txtSifre.Name = "txtSifre";
            txtSifre.Properties.UseSystemPasswordChar = true;
            txtSifre.ShowToolTips = false;
            txtSifre.Size = new Size(139, 28);
            txtSifre.TabIndex = 11;
            // 
            // chkbtnBeniHatirla
            // 
            chkbtnBeniHatirla.Location = new Point(235, 184);
            chkbtnBeniHatirla.Name = "chkbtnBeniHatirla";
            chkbtnBeniHatirla.Size = new Size(22, 20);
            chkbtnBeniHatirla.TabIndex = 12;
            chkbtnBeniHatirla.CheckedChanged += chkbtnBeniHatirla_CheckedChanged;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(263, 184);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(66, 17);
            labelControl1.TabIndex = 13;
            labelControl1.Text = "Beni Hatırla";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(140, 120);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(93, 21);
            labelControl2.TabIndex = 14;
            labelControl2.Text = "Kullanıcı Adı:";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(195, 157);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(38, 21);
            labelControl3.TabIndex = 15;
            labelControl3.Text = "Şifre:";
            // 
            // btnGirisYap
            // 
            btnGirisYap.Appearance.BackColor = Color.SteelBlue;
            btnGirisYap.Appearance.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.Appearance.ForeColor = Color.Black;
            btnGirisYap.Appearance.Options.UseBackColor = true;
            btnGirisYap.Appearance.Options.UseFont = true;
            btnGirisYap.Appearance.Options.UseForeColor = true;
            btnGirisYap.AppearanceHovered.BackColor = Color.SteelBlue;
            btnGirisYap.AppearanceHovered.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.AppearanceHovered.ForeColor = Color.Black;
            btnGirisYap.AppearanceHovered.Options.UseBackColor = true;
            btnGirisYap.AppearanceHovered.Options.UseFont = true;
            btnGirisYap.AppearanceHovered.Options.UseForeColor = true;
            btnGirisYap.Location = new Point(263, 210);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(89, 32);
            btnGirisYap.TabIndex = 16;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnGirisYap;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 281);
            Controls.Add(btnGirisYap);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(chkbtnBeniHatirla);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("frmLogin.IconOptions.SvgImage");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Girişi";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.CheckButton chkbtnBeniHatirla;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
    }
}