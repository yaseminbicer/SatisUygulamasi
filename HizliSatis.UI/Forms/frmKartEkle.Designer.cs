namespace HizliSatis.UI.Forms
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
            txtBirimi.Location = new Point(144, 83);
            txtBirimi.Margin = new Padding(3, 4, 3, 4);
            txtBirimi.Name = "txtBirimi";
            txtBirimi.Size = new Size(96, 22);
            txtBirimi.TabIndex = 33;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(144, 137);
            txtMiktar.Margin = new Padding(3, 4, 3, 4);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(96, 22);
            txtMiktar.TabIndex = 34;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.EditValue = "";
            txtUrunAdi.Location = new Point(144, 39);
            txtUrunAdi.Margin = new Padding(3, 4, 3, 4);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(96, 22);
            txtUrunAdi.TabIndex = 31;
            // 
            // Miktar
            // 
            Miktar.AutoSize = true;
            Miktar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Miktar.Location = new Point(62, 139);
            Miktar.Name = "Miktar";
            Miktar.Size = new Size(76, 28);
            Miktar.TabIndex = 38;
            Miktar.Text = "Miktar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 84);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 37;
            label2.Text = "Birimi:";
            // 
            // UrunAdi
            // 
            UrunAdi.AutoSize = true;
            UrunAdi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UrunAdi.Location = new Point(43, 40);
            UrunAdi.Name = "UrunAdi";
            UrunAdi.Size = new Size(98, 28);
            UrunAdi.TabIndex = 35;
            UrunAdi.Text = "Ürün Adı:";
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.EditValue = "0";
            txtAlisFiyati.Location = new Point(448, 39);
            txtAlisFiyati.Margin = new Padding(3, 4, 3, 4);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(96, 22);
            txtAlisFiyati.TabIndex = 39;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.EditValue = "0";
            txtSatisFiyati.Location = new Point(448, 83);
            txtSatisFiyati.Margin = new Padding(3, 4, 3, 4);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(96, 22);
            txtSatisFiyati.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(338, 91);
            label7.Name = "label7";
            label7.Size = new Size(112, 28);
            label7.TabIndex = 44;
            label7.Text = "Satış Fiyatı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(347, 39);
            label8.Name = "label8";
            label8.Size = new Size(102, 28);
            label8.TabIndex = 43;
            label8.Text = "Alış Fiyatı:";
            // 
            // txtToplam
            // 
            txtToplam.Location = new Point(448, 137);
            txtToplam.Margin = new Padding(3, 4, 3, 4);
            txtToplam.Name = "txtToplam";
            txtToplam.Size = new Size(96, 22);
            txtToplam.TabIndex = 47;
            // 
            // Toplam
            // 
            Toplam.AutoSize = true;
            Toplam.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Toplam.Location = new Point(365, 139);
            Toplam.Name = "Toplam";
            Toplam.Size = new Size(83, 28);
            Toplam.TabIndex = 48;
            Toplam.Text = "Toplam:";
            // 
            // btnKaydetCik
            // 
            btnKaydetCik.Appearance.BackColor = Color.FromArgb(192, 192, 0);
            btnKaydetCik.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydetCik.Appearance.Options.UseBackColor = true;
            btnKaydetCik.Appearance.Options.UseFont = true;
            btnKaydetCik.Location = new Point(370, 208);
            btnKaydetCik.Margin = new Padding(3, 4, 3, 4);
            btnKaydetCik.Name = "btnKaydetCik";
            btnKaydetCik.Size = new Size(127, 67);
            btnKaydetCik.TabIndex = 50;
            btnKaydetCik.Text = "Kaydet ve Çık";
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.BackColor = Color.Green;
            btnKaydet.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseBackColor = true;
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.Location = new Point(267, 208);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(96, 67);
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
            btnIptal.Location = new Point(514, 208);
            btnIptal.Margin = new Padding(3, 4, 3, 4);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(96, 67);
            btnIptal.TabIndex = 52;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 191);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 46;
            label3.Text = "KDV Oranı:";
            // 
            // txtKdvOrani
            // 
            txtKdvOrani.Location = new Point(144, 189);
            txtKdvOrani.Margin = new Padding(3, 4, 3, 4);
            txtKdvOrani.Name = "txtKdvOrani";
            txtKdvOrani.Size = new Size(96, 22);
            txtKdvOrani.TabIndex = 42;
            // 
            // txtId
            // 
            txtId.EditValue = "0";
            txtId.Location = new Point(591, 39);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(120, 22);
            txtId.TabIndex = 53;
            txtId.Visible = false;
            // 
            // frmKartEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 296);
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
            Margin = new Padding(3, 4, 3, 4);
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