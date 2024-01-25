namespace HizliSatis.UI.Forms
{
    partial class frmKategoriDetay
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
            btnIptal = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // btnIptal
            // 
            btnIptal.Appearance.BackColor = Color.FromArgb(67, 85, 167);
            btnIptal.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIptal.Appearance.Options.UseBackColor = true;
            btnIptal.Appearance.Options.UseFont = true;
            btnIptal.AppearanceDisabled.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIptal.AppearanceDisabled.Options.UseFont = true;
            btnIptal.Location = new Point(745, 478);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(109, 37);
            btnIptal.TabIndex = 6;
            btnIptal.Text = "İptal";
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            btnKaydet.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseBackColor = true;
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.AppearanceDisabled.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.AppearanceDisabled.Options.UseFont = true;
            btnKaydet.Location = new Point(860, 478);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(109, 37);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            // 
            // frmKategoriDetay
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 527);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            Name = "frmKategoriDetay";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}