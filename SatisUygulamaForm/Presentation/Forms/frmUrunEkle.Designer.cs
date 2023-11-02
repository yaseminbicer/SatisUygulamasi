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
            txtBirimi = new DevExpress.XtraEditors.TextEdit();
            txtUrunGrubu = new DevExpress.XtraEditors.TextEdit();
            txtId = new DevExpress.XtraEditors.TextEdit();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnKaydetCik = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            btnIptal = new DevExpress.XtraEditors.SimpleButton();
            txtKdvOrani = new DevExpress.XtraEditors.TextEdit();
            txtAlisFiyati = new DevExpress.XtraEditors.TextEdit();
            txtSatisFiyati = new DevExpress.XtraEditors.TextEdit();
            txtBarkod = new DevExpress.XtraEditors.TextEdit();
            txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            txtUrunAciklama = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            gridUrunEkle = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBirimi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunGrubu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKdvOrani.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAlisFiyati.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSatisFiyati.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBarkod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAciklama.Properties).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridUrunEkle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
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
            tableLayoutPanel1.Size = new Size(723, 543);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBirimi);
            panel1.Controls.Add(txtUrunGrubu);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(btnKaydetCik);
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(btnIptal);
            panel1.Controls.Add(txtKdvOrani);
            panel1.Controls.Add(txtAlisFiyati);
            panel1.Controls.Add(txtSatisFiyati);
            panel1.Controls.Add(txtBarkod);
            panel1.Controls.Add(txtUrunAdi);
            panel1.Controls.Add(txtUrunAciklama);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 265);
            panel1.TabIndex = 0;
            // 
            // txtBirimi
            // 
            txtBirimi.Location = new Point(478, 107);
            txtBirimi.Name = "txtBirimi";
            txtBirimi.Size = new Size(84, 28);
            txtBirimi.TabIndex = 6;
            // 
            // txtUrunGrubu
            // 
            txtUrunGrubu.Location = new Point(129, 147);
            txtUrunGrubu.Name = "txtUrunGrubu";
            txtUrunGrubu.Size = new Size(177, 28);
            txtUrunGrubu.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.EditValue = "0";
            txtId.Location = new Point(591, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(105, 28);
            txtId.TabIndex = 46;
            txtId.Visible = false;
            // 
            // btnSil
            // 
            btnSil.Appearance.BackColor = Color.Red;
            btnSil.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Appearance.ForeColor = Color.Black;
            btnSil.Appearance.Options.UseBackColor = true;
            btnSil.Appearance.Options.UseFont = true;
            btnSil.Appearance.Options.UseForeColor = true;
            btnSil.Location = new Point(452, 204);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(56, 50);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydetCik
            // 
            btnKaydetCik.Appearance.BackColor = Color.FromArgb(192, 192, 0);
            btnKaydetCik.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydetCik.Appearance.Options.UseBackColor = true;
            btnKaydetCik.Appearance.Options.UseFont = true;
            btnKaydetCik.Location = new Point(337, 204);
            btnKaydetCik.Name = "btnKaydetCik";
            btnKaydetCik.Size = new Size(111, 50);
            btnKaydetCik.TabIndex = 9;
            btnKaydetCik.Text = "Kaydet ve Çık";
            btnKaydetCik.Click += btnKaydetCik_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.BackColor = Color.Green;
            btnKaydet.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseBackColor = true;
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.Location = new Point(247, 204);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(84, 50);
            btnKaydet.TabIndex = 8;
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
            btnIptal.Location = new Point(513, 204);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(84, 50);
            btnIptal.TabIndex = 11;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            // 
            // txtKdvOrani
            // 
            txtKdvOrani.Location = new Point(478, 141);
            txtKdvOrani.Name = "txtKdvOrani";
            txtKdvOrani.Size = new Size(84, 28);
            txtKdvOrani.TabIndex = 7;
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.EditValue = "0";
            txtAlisFiyati.Location = new Point(478, 42);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(84, 28);
            txtAlisFiyati.TabIndex = 4;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.EditValue = "0";
            txtSatisFiyati.Location = new Point(478, 75);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(84, 28);
            txtSatisFiyati.TabIndex = 5;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(129, 40);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(177, 28);
            txtBarkod.TabIndex = 0;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(129, 73);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(177, 28);
            txtUrunAdi.TabIndex = 1;
            // 
            // txtUrunAciklama
            // 
            txtUrunAciklama.Location = new Point(129, 107);
            txtUrunAciklama.Name = "txtUrunAciklama";
            txtUrunAciklama.Size = new Size(177, 28);
            txtUrunAciklama.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(384, 149);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 30;
            label1.Text = "KDV Oranı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(416, 117);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 26;
            label2.Text = "Birimi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(382, 81);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 24;
            label4.Text = "Satış Fiyatı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(390, 42);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 23;
            label5.Text = "Alış Fiyatı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(25, 148);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 19;
            label6.Text = "Ürün Grubu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(5, 116);
            label7.Name = "label7";
            label7.Size = new Size(118, 21);
            label7.TabIndex = 18;
            label7.Text = "Ürün Açıklama:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(45, 80);
            label8.Name = "label8";
            label8.Size = new Size(78, 21);
            label8.TabIndex = 17;
            label8.Text = "Ürün Adı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(57, 47);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 16;
            label9.Text = "Barkod:";
            // 
            // panel2
            // 
            panel2.Controls.Add(gridUrunEkle);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(717, 266);
            panel2.TabIndex = 1;
            // 
            // gridUrunEkle
            // 
            gridUrunEkle.Dock = DockStyle.Fill;
            gridUrunEkle.Location = new Point(0, 0);
            gridUrunEkle.MainView = gridView1;
            gridUrunEkle.Name = "gridUrunEkle";
            gridUrunEkle.Size = new Size(717, 266);
            gridUrunEkle.TabIndex = 0;
            gridUrunEkle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 303;
            gridView1.GridControl = gridUrunEkle;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmUrunEkle
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 543);
            Controls.Add(tableLayoutPanel1);
            Name = "frmUrunEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekle";
            Load += frmUrunEkle_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBirimi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunGrubu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKdvOrani.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAlisFiyati.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSatisFiyati.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBarkod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAciklama.Properties).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridUrunEkle).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtKdvOrani;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyati;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyati;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.TextEdit txtUrunAciklama;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraGrid.GridControl gridUrunEkle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnKaydetCik;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtBirimi;
        private DevExpress.XtraEditors.TextEdit txtUrunGrubu;
    }
}