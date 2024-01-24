namespace HizliSatis.UI.Forms
{
    partial class frmAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaMenu));
            panelMenu = new Panel();
            sidePanel = new Panel();
            btnRaporlar = new Button();
            btnFisveFaturalar = new Button();
            btnOdemeTanimlama = new Button();
            btnKullanicilar = new Button();
            btnKasaTanimlama = new Button();
            btnKategoriler = new Button();
            btnStok = new Button();
            panelMain = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(41, 39, 40);
            panelMenu.Controls.Add(sidePanel);
            panelMenu.Controls.Add(btnRaporlar);
            panelMenu.Controls.Add(btnFisveFaturalar);
            panelMenu.Controls.Add(btnOdemeTanimlama);
            panelMenu.Controls.Add(btnKullanicilar);
            panelMenu.Controls.Add(btnKasaTanimlama);
            panelMenu.Controls.Add(btnKategoriler);
            panelMenu.Controls.Add(btnStok);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.FromArgb(49, 55, 40);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(243, 751);
            panelMenu.TabIndex = 0;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(67, 85, 167);
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(13, 87);
            sidePanel.TabIndex = 1;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Dock = DockStyle.Top;
            btnRaporlar.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btnRaporlar.FlatStyle = FlatStyle.Flat;
            btnRaporlar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaporlar.ForeColor = Color.White;
            btnRaporlar.Image = (Image)resources.GetObject("btnRaporlar.Image");
            btnRaporlar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRaporlar.Location = new Point(0, 522);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(243, 87);
            btnRaporlar.TabIndex = 6;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnFisveFaturalar
            // 
            btnFisveFaturalar.Dock = DockStyle.Top;
            btnFisveFaturalar.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btnFisveFaturalar.FlatStyle = FlatStyle.Flat;
            btnFisveFaturalar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFisveFaturalar.ForeColor = Color.White;
            btnFisveFaturalar.Image = (Image)resources.GetObject("btnFisveFaturalar.Image");
            btnFisveFaturalar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFisveFaturalar.Location = new Point(0, 435);
            btnFisveFaturalar.Name = "btnFisveFaturalar";
            btnFisveFaturalar.Size = new Size(243, 87);
            btnFisveFaturalar.TabIndex = 5;
            btnFisveFaturalar.Text = "Fiş ve Faturalar";
            btnFisveFaturalar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFisveFaturalar.UseVisualStyleBackColor = true;
            btnFisveFaturalar.Click += btnFisveFaturalar_Click;
            // 
            // btnOdemeTanimlama
            // 
            btnOdemeTanimlama.Dock = DockStyle.Top;
            btnOdemeTanimlama.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btnOdemeTanimlama.FlatStyle = FlatStyle.Flat;
            btnOdemeTanimlama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOdemeTanimlama.ForeColor = Color.White;
            btnOdemeTanimlama.Image = Properties.Resources.payment_method_svgrepo_com;
            btnOdemeTanimlama.ImageAlign = ContentAlignment.MiddleLeft;
            btnOdemeTanimlama.Location = new Point(0, 348);
            btnOdemeTanimlama.Name = "btnOdemeTanimlama";
            btnOdemeTanimlama.Size = new Size(243, 87);
            btnOdemeTanimlama.TabIndex = 4;
            btnOdemeTanimlama.Text = "Ödeme Tanımlama";
            btnOdemeTanimlama.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOdemeTanimlama.UseVisualStyleBackColor = true;
            btnOdemeTanimlama.Click += btnOdemeTanimlama_Click;
            // 
            // btnKullanicilar
            // 
            btnKullanicilar.Dock = DockStyle.Top;
            btnKullanicilar.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btnKullanicilar.FlatStyle = FlatStyle.Flat;
            btnKullanicilar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKullanicilar.ForeColor = Color.White;
            btnKullanicilar.Image = (Image)resources.GetObject("btnKullanicilar.Image");
            btnKullanicilar.ImageAlign = ContentAlignment.MiddleLeft;
            btnKullanicilar.Location = new Point(0, 261);
            btnKullanicilar.Name = "btnKullanicilar";
            btnKullanicilar.Size = new Size(243, 87);
            btnKullanicilar.TabIndex = 3;
            btnKullanicilar.Text = "Kullanıcılar";
            btnKullanicilar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKullanicilar.UseVisualStyleBackColor = true;
            btnKullanicilar.Click += btnKullanicilar_Click;
            // 
            // btnKasaTanimlama
            // 
            btnKasaTanimlama.Dock = DockStyle.Top;
            btnKasaTanimlama.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btnKasaTanimlama.FlatStyle = FlatStyle.Flat;
            btnKasaTanimlama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKasaTanimlama.ForeColor = Color.White;
            btnKasaTanimlama.Image = (Image)resources.GetObject("btnKasaTanimlama.Image");
            btnKasaTanimlama.ImageAlign = ContentAlignment.MiddleLeft;
            btnKasaTanimlama.Location = new Point(0, 174);
            btnKasaTanimlama.Name = "btnKasaTanimlama";
            btnKasaTanimlama.Size = new Size(243, 87);
            btnKasaTanimlama.TabIndex = 2;
            btnKasaTanimlama.Text = "Kasa Tanımlama";
            btnKasaTanimlama.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKasaTanimlama.UseVisualStyleBackColor = true;
            btnKasaTanimlama.Click += btnKasaTanimlama_Click;
            // 
            // btnKategoriler
            // 
            btnKategoriler.Dock = DockStyle.Top;
            btnKategoriler.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btnKategoriler.FlatStyle = FlatStyle.Flat;
            btnKategoriler.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKategoriler.ForeColor = Color.White;
            btnKategoriler.Image = (Image)resources.GetObject("btnKategoriler.Image");
            btnKategoriler.ImageAlign = ContentAlignment.MiddleLeft;
            btnKategoriler.Location = new Point(0, 87);
            btnKategoriler.Name = "btnKategoriler";
            btnKategoriler.Size = new Size(243, 87);
            btnKategoriler.TabIndex = 1;
            btnKategoriler.Text = "Kategoriler";
            btnKategoriler.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKategoriler.UseVisualStyleBackColor = true;
            btnKategoriler.Click += btnKategoriler_Click;
            // 
            // btnStok
            // 
            btnStok.Dock = DockStyle.Top;
            btnStok.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btnStok.FlatStyle = FlatStyle.Flat;
            btnStok.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStok.ForeColor = Color.White;
            btnStok.Image = (Image)resources.GetObject("btnStok.Image");
            btnStok.ImageAlign = ContentAlignment.MiddleLeft;
            btnStok.Location = new Point(0, 0);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(243, 87);
            btnStok.TabIndex = 0;
            btnStok.Text = "Stok";
            btnStok.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStok.UseVisualStyleBackColor = true;
            btnStok.Click += btnStok_Click_1;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(243, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(814, 751);
            panelMain.TabIndex = 1;
            // 
            // frmAnaMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 751);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHome";
            Load += frmAnaMenu_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private Button btnRaporlar;
        private Button btnFisveFaturalar;
        private Button btnOdemeTanimlama;
        private Button btnKullanicilar;
        private Button btnKasaTanimlama;
        private Button btnKategoriler;
        private Button btnStok;
        private Panel sidePanel;
        private Panel panelMain;
    }
}