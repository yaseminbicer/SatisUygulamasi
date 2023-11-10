namespace HizliSatis.Form.Forms.Presentation.Forms
{
    partial class frmStokListesi
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
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            btnEkle = new DevExpress.XtraEditors.SimpleButton();
            btnIptal = new DevExpress.XtraEditors.SimpleButton();
            gridStokListesi = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)gridStokListesi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.Appearance.BackColor = Color.Red;
            btnSil.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Appearance.ForeColor = Color.Black;
            btnSil.Appearance.Options.UseBackColor = true;
            btnSil.Appearance.Options.UseFont = true;
            btnSil.Appearance.Options.UseForeColor = true;
            btnSil.Location = new Point(640, 24);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(56, 50);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Appearance.BackColor = Color.FromArgb(192, 192, 0);
            btnDuzenle.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDuzenle.Appearance.Options.UseBackColor = true;
            btnDuzenle.Appearance.Options.UseFont = true;
            btnDuzenle.Location = new Point(525, 24);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(111, 50);
            btnDuzenle.TabIndex = 13;
            btnDuzenle.Text = "Düzenle";
            // 
            // btnEkle
            // 
            btnEkle.Appearance.BackColor = Color.Green;
            btnEkle.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Appearance.Options.UseBackColor = true;
            btnEkle.Appearance.Options.UseFont = true;
            btnEkle.Location = new Point(435, 24);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(84, 50);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // btnIptal
            // 
            btnIptal.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            btnIptal.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIptal.Appearance.ForeColor = Color.Black;
            btnIptal.Appearance.Options.UseBackColor = true;
            btnIptal.Appearance.Options.UseFont = true;
            btnIptal.Appearance.Options.UseForeColor = true;
            btnIptal.Location = new Point(701, 24);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(84, 50);
            btnIptal.TabIndex = 15;
            btnIptal.Text = "İptal";
            // 
            // gridStokListesi
            // 
            gridStokListesi.Location = new Point(45, 104);
            gridStokListesi.MainView = gridView1;
            gridStokListesi.Name = "gridStokListesi";
            gridStokListesi.Size = new Size(724, 310);
            gridStokListesi.TabIndex = 16;
            gridStokListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridStokListesi;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.RowClick += gridView1_RowClick;
            // 
            // frmStokListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridStokListesi);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(btnEkle);
            Controls.Add(btnIptal);
            Name = "frmStokListesi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStokListesi";
            Load += frmStokListesi_Load;
            ((System.ComponentModel.ISupportInitialize)gridStokListesi).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraGrid.GridControl gridStokListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}