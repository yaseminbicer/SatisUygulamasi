namespace SatisUygulamaForm.Presentation.Forms
{
    partial class frmKartEkle
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
            txtBirimi = new DevExpress.XtraEditors.TextEdit();
            txtMiktar = new DevExpress.XtraEditors.TextEdit();
            txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            Miktar = new Label();
            label2 = new Label();
            UrunAdi = new Label();
            txtAlisFiyati = new DevExpress.XtraEditors.TextEdit();
            txtSatisFiyati = new DevExpress.XtraEditors.TextEdit();
            label7 = new Label();
            label8 = new Label();
            txtToplam = new DevExpress.XtraEditors.TextEdit();
            Toplam = new Label();
            btnKaydetCik = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            btnIptal = new DevExpress.XtraEditors.SimpleButton();
            label3 = new Label();
            txtKdvOrani = new DevExpress.XtraEditors.TextEdit();
            txtId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)txtBirimi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMiktar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAlisFiyati.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSatisFiyati.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtToplam.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKdvOrani.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtBirimi
            // 
            txtBirimi.Location = new Point(126, 62);
            txtBirimi.Name = "txtBirimi";
            txtBirimi.Size = new Size(84, 28);
            txtBirimi.TabIndex = 33;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(126, 103);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(84, 28);
            txtMiktar.TabIndex = 34;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.EditValue = "";
            txtUrunAdi.Location = new Point(126, 29);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(84, 28);
            txtUrunAdi.TabIndex = 31;
            // 
            // Miktar
            // 
            Miktar.AutoSize = true;
            Miktar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Miktar.Location = new Point(54, 104);
            Miktar.Name = "Miktar";
            Miktar.Size = new Size(62, 21);
            Miktar.TabIndex = 38;
            Miktar.Text = "Miktar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(60, 63);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 37;
            label2.Text = "Birimi:";
            // 
            // UrunAdi
            // 
            UrunAdi.AutoSize = true;
            UrunAdi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UrunAdi.Location = new Point(38, 30);
            UrunAdi.Name = "UrunAdi";
            UrunAdi.Size = new Size(78, 21);
            UrunAdi.TabIndex = 35;
            UrunAdi.Text = "Ürün Adı:";
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.EditValue = "0";
            txtAlisFiyati.Location = new Point(392, 29);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(84, 28);
            txtAlisFiyati.TabIndex = 39;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.EditValue = "0";
            txtSatisFiyati.Location = new Point(392, 62);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(84, 28);
            txtSatisFiyati.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(296, 68);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 44;
            label7.Text = "Satış Fiyatı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(304, 29);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 43;
            label8.Text = "Alış Fiyatı:";
            // 
            // txtToplam
            // 
            txtToplam.Location = new Point(392, 103);
            txtToplam.Name = "txtToplam";
            txtToplam.Size = new Size(84, 28);
            txtToplam.TabIndex = 47;
            // 
            // Toplam
            // 
            Toplam.AutoSize = true;
            Toplam.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Toplam.Location = new Point(319, 104);
            Toplam.Name = "Toplam";
            Toplam.Size = new Size(67, 21);
            Toplam.TabIndex = 48;
            Toplam.Text = "Toplam:";
            // 
            // btnKaydetCik
            // 
            btnKaydetCik.Appearance.BackColor = Color.FromArgb(192, 192, 0);
            btnKaydetCik.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydetCik.Appearance.Options.UseBackColor = true;
            btnKaydetCik.Appearance.Options.UseFont = true;
            btnKaydetCik.Location = new Point(324, 156);
            btnKaydetCik.Name = "btnKaydetCik";
            btnKaydetCik.Size = new Size(111, 50);
            btnKaydetCik.TabIndex = 50;
            btnKaydetCik.Text = "Kaydet ve Çık";
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.BackColor = Color.Green;
            btnKaydet.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseBackColor = true;
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.Location = new Point(234, 156);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(84, 50);
            btnKaydet.TabIndex = 49;
            btnKaydet.Text = "Kaydet";
            // 
            // btnIptal
            // 
            btnIptal.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            btnIptal.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIptal.Appearance.ForeColor = Color.Black;
            btnIptal.Appearance.Options.UseBackColor = true;
            btnIptal.Appearance.Options.UseFont = true;
            btnIptal.Appearance.Options.UseForeColor = true;
            btnIptal.Location = new Point(450, 156);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(84, 50);
            btnIptal.TabIndex = 52;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 143);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 46;
            label3.Text = "KDV Oranı:";
            // 
            // txtKdvOrani
            // 
            txtKdvOrani.Location = new Point(126, 142);
            txtKdvOrani.Name = "txtKdvOrani";
            txtKdvOrani.Size = new Size(84, 28);
            txtKdvOrani.TabIndex = 42;
            // 
            // txtId
            // 
            txtId.EditValue = "0";
            txtId.Location = new Point(517, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(105, 28);
            txtId.TabIndex = 53;
            txtId.Visible = false;
            // 
            // frmKartEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 222);
            Controls.Add(txtId);
            Controls.Add(btnKaydetCik);
            Controls.Add(btnKaydet);
            Controls.Add(btnIptal);
            Controls.Add(txtToplam);
            Controls.Add(Toplam);
            Controls.Add(txtKdvOrani);
            Controls.Add(txtAlisFiyati);
            Controls.Add(txtSatisFiyati);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtBirimi);
            Controls.Add(txtMiktar);
            Controls.Add(txtUrunAdi);
            Controls.Add(Miktar);
            Controls.Add(label2);
            Controls.Add(UrunAdi);
            Name = "frmKartEkle";
            Text = "frmKartEkle";
            ((System.ComponentModel.ISupportInitialize)txtBirimi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMiktar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAlisFiyati.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSatisFiyati.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtToplam.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKdvOrani.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBirimi;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private Label Miktar;
        private Label label2;
        private Label UrunAdi;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyati;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyati;
        private Label label7;
        private Label label8;
        private DevExpress.XtraEditors.TextEdit txtToplam;
        private Label Toplam;
        private DevExpress.XtraEditors.SimpleButton btnKaydetCik;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit txtKdvOrani;
        private DevExpress.XtraEditors.TextEdit txtId;
    }
}