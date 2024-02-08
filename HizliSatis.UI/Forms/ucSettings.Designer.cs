namespace HizliSatis.UI.Forms
{
    partial class ucSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCikis = new DevExpress.XtraEditors.SimpleButton();
            btnStokListesi = new DevExpress.XtraEditors.SimpleButton();
            btnKullaniciDegistir = new DevExpress.XtraEditors.SimpleButton();
            btnMusteriler = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // btnCikis
            // 
            btnCikis.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCikis.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.Appearance.ForeColor = Color.Black;
            btnCikis.Appearance.Options.UseBackColor = true;
            btnCikis.Appearance.Options.UseFont = true;
            btnCikis.Appearance.Options.UseForeColor = true;
            btnCikis.Location = new Point(32, 253);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(256, 33);
            btnCikis.TabIndex = 1;
            btnCikis.Text = "Çıkış";
            btnCikis.Click += btnCikis_Click;
            // 
            // btnStokListesi
            // 
            btnStokListesi.Appearance.BackColor = Color.FromArgb(67, 85, 167);
            btnStokListesi.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStokListesi.Appearance.Options.UseBackColor = true;
            btnStokListesi.Appearance.Options.UseFont = true;
            btnStokListesi.Location = new Point(170, 146);
            btnStokListesi.Name = "btnStokListesi";
            btnStokListesi.Size = new Size(118, 72);
            btnStokListesi.TabIndex = 2;
            btnStokListesi.Text = "Stok Listesi";
            btnStokListesi.Click += btnStokListesi_Click;
            // 
            // btnKullaniciDegistir
            // 
            btnKullaniciDegistir.Appearance.BackColor = Color.FromArgb(169, 187, 230);
            btnKullaniciDegistir.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKullaniciDegistir.Appearance.ForeColor = Color.Black;
            btnKullaniciDegistir.Appearance.Options.UseBackColor = true;
            btnKullaniciDegistir.Appearance.Options.UseFont = true;
            btnKullaniciDegistir.Appearance.Options.UseForeColor = true;
            btnKullaniciDegistir.Location = new Point(32, 146);
            btnKullaniciDegistir.Name = "btnKullaniciDegistir";
            btnKullaniciDegistir.Size = new Size(118, 72);
            btnKullaniciDegistir.TabIndex = 3;
            btnKullaniciDegistir.Text = "Kullanıcı Değiştir";
            btnKullaniciDegistir.Click += btnKullaniciDegistir_Click;
            // 
            // btnMusteriler
            // 
            btnMusteriler.Appearance.BackColor = Color.FromArgb(169, 187, 230);
            btnMusteriler.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMusteriler.Appearance.ForeColor = Color.Black;
            btnMusteriler.Appearance.Options.UseBackColor = true;
            btnMusteriler.Appearance.Options.UseFont = true;
            btnMusteriler.Appearance.Options.UseForeColor = true;
            btnMusteriler.Location = new Point(170, 36);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(118, 72);
            btnMusteriler.TabIndex = 4;
            btnMusteriler.Text = "Müşteriler";
            btnMusteriler.Click += btnMusteriler_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.BackColor = Color.FromArgb(67, 85, 167);
            simpleButton2.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            simpleButton2.Appearance.Options.UseBackColor = true;
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Location = new Point(32, 36);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(118, 72);
            simpleButton2.TabIndex = 5;
            simpleButton2.Text = "Kasa Yönetimi";
            // 
            // ucSettings
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(simpleButton2);
            Controls.Add(btnMusteriler);
            Controls.Add(btnKullaniciDegistir);
            Controls.Add(btnStokListesi);
            Controls.Add(btnCikis);
            Location = new Point(316, 243);
            Name = "ucSettings";
            Size = new Size(323, 327);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.SimpleButton btnStokListesi;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciDegistir;
        private DevExpress.XtraEditors.SimpleButton btnMusteriler;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
