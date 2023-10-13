namespace SatisUygulamaForm
{
    partial class frmUrunEkle
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            btnIptal = new DevExpress.XtraEditors.SimpleButton();
            btnBarkodOlustur = new DevExpress.XtraEditors.SimpleButton();
            btnUrunGrubuEkle = new DevExpress.XtraEditors.SimpleButton();
            txtKdvOrani = new DevExpress.XtraEditors.TextEdit();
            txtAlisFiyati = new DevExpress.XtraEditors.TextEdit();
            txtSatisFiyati = new DevExpress.XtraEditors.TextEdit();
            txtMiktar = new DevExpress.XtraEditors.TextEdit();
            txtBarkod = new DevExpress.XtraEditors.TextEdit();
            txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            txtUrunAciklama = new DevExpress.XtraEditors.TextEdit();
            cmbxBrimi = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            cmbxUrunGrubu = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtKdvOrani.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAlisFiyati.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSatisFiyati.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMiktar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBarkod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAciklama.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbxBrimi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbxUrunGrubu.Properties).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(821, 496);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(btnIptal);
            panel1.Controls.Add(btnBarkodOlustur);
            panel1.Controls.Add(btnUrunGrubuEkle);
            panel1.Controls.Add(txtKdvOrani);
            panel1.Controls.Add(txtAlisFiyati);
            panel1.Controls.Add(txtSatisFiyati);
            panel1.Controls.Add(txtMiktar);
            panel1.Controls.Add(txtBarkod);
            panel1.Controls.Add(txtUrunAdi);
            panel1.Controls.Add(txtUrunAciklama);
            panel1.Controls.Add(cmbxBrimi);
            panel1.Controls.Add(cmbxUrunGrubu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 242);
            panel1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.BackColor = Color.OrangeRed;
            btnKaydet.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseBackColor = true;
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.Location = new Point(603, 169);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(98, 58);
            btnKaydet.TabIndex = 43;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            btnIptal.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIptal.Appearance.ForeColor = Color.Black;
            btnIptal.Appearance.Options.UseBackColor = true;
            btnIptal.Appearance.Options.UseFont = true;
            btnIptal.Appearance.Options.UseForeColor = true;
            btnIptal.Location = new Point(499, 169);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(98, 58);
            btnIptal.TabIndex = 42;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            // 
            // btnBarkodOlustur
            // 
            btnBarkodOlustur.Appearance.BackColor = Color.FromArgb(128, 64, 0);
            btnBarkodOlustur.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBarkodOlustur.Appearance.Options.UseBackColor = true;
            btnBarkodOlustur.Appearance.Options.UseFont = true;
            btnBarkodOlustur.Location = new Point(255, 169);
            btnBarkodOlustur.Name = "btnBarkodOlustur";
            btnBarkodOlustur.Size = new Size(101, 58);
            btnBarkodOlustur.TabIndex = 41;
            btnBarkodOlustur.Text = "Barkod \r\nOluştur";
            btnBarkodOlustur.Click += btnBarkodOlustur_Click;
            // 
            // btnUrunGrubuEkle
            // 
            btnUrunGrubuEkle.Appearance.BackColor = Color.FromArgb(255, 224, 192);
            btnUrunGrubuEkle.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUrunGrubuEkle.Appearance.Options.UseBackColor = true;
            btnUrunGrubuEkle.Appearance.Options.UseFont = true;
            btnUrunGrubuEkle.Location = new Point(150, 169);
            btnUrunGrubuEkle.Name = "btnUrunGrubuEkle";
            btnUrunGrubuEkle.Size = new Size(99, 58);
            btnUrunGrubuEkle.TabIndex = 40;
            btnUrunGrubuEkle.Text = "Ürün Grubu\r\nEkle";
            btnUrunGrubuEkle.Click += btnUrunGrubuEkle_Click;
            // 
            // txtKdvOrani
            // 
            txtKdvOrani.Location = new Point(603, 135);
            txtKdvOrani.Name = "txtKdvOrani";
            txtKdvOrani.Size = new Size(98, 28);
            txtKdvOrani.TabIndex = 39;
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.EditValue = "0";
            txtAlisFiyati.Location = new Point(499, 36);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(98, 28);
            txtAlisFiyati.TabIndex = 38;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.EditValue = "0";
            txtSatisFiyati.Location = new Point(499, 72);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(98, 28);
            txtSatisFiyati.TabIndex = 37;
            // 
            // txtMiktar
            // 
            txtMiktar.EditValue = "0";
            txtMiktar.Location = new Point(499, 103);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(98, 28);
            txtMiktar.TabIndex = 36;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(150, 38);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(206, 28);
            txtBarkod.TabIndex = 34;
            txtBarkod.EditValueChanged += txtBarkod_EditValueChanged;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(150, 72);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(206, 28);
            txtUrunAdi.TabIndex = 33;
            // 
            // txtUrunAciklama
            // 
            txtUrunAciklama.Location = new Point(150, 103);
            txtUrunAciklama.Name = "txtUrunAciklama";
            txtUrunAciklama.Size = new Size(206, 28);
            txtUrunAciklama.TabIndex = 0;
            // 
            // cmbxBrimi
            // 
            cmbxBrimi.Location = new Point(499, 135);
            cmbxBrimi.Name = "cmbxBrimi";
            cmbxBrimi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbxBrimi.Size = new Size(98, 28);
            cmbxBrimi.TabIndex = 32;
            // 
            // cmbxUrunGrubu
            // 
            cmbxUrunGrubu.Location = new Point(150, 135);
            cmbxUrunGrubu.Name = "cmbxUrunGrubu";
            cmbxUrunGrubu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbxUrunGrubu.Size = new Size(206, 28);
            cmbxUrunGrubu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(603, 104);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 30;
            label1.Text = "KDV Oranı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(441, 136);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 26;
            label2.Text = "Birimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(436, 104);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 25;
            label3.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(407, 73);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 24;
            label4.Text = "Satış Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(415, 39);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 23;
            label5.Text = "Alış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(50, 142);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 19;
            label6.Text = "Ürün Grubu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(30, 110);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 18;
            label7.Text = "Ürün Açıklama";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(70, 79);
            label8.Name = "label8";
            label8.Size = new Size(74, 21);
            label8.TabIndex = 17;
            label8.Text = "Ürün Adı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(82, 45);
            label9.Name = "label9";
            label9.Size = new Size(62, 21);
            label9.TabIndex = 16;
            label9.Text = "Barkod";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 251);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 242);
            panel2.TabIndex = 1;
            // 
            // frmUrunEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 496);
            Controls.Add(tableLayoutPanel1);
            Name = "frmUrunEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekle";
            Load += frmUrunEkle_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtKdvOrani.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAlisFiyati.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSatisFiyati.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMiktar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBarkod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAciklama.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbxBrimi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbxUrunGrubu.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbxBrimi;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbxUrunGrubu;
        private DevExpress.XtraEditors.SimpleButton btnBarkodOlustur;
        private DevExpress.XtraEditors.SimpleButton btnUrunGrubuEkle;
        private DevExpress.XtraEditors.TextEdit txtKdvOrani;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyati;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyati;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.TextEdit txtUrunAciklama;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
    }
}