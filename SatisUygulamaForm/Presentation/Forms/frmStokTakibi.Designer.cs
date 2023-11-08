namespace SatisUygulamaForm.Presentation.Forms
{
    partial class frmStokTakibi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokTakibi));
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            btnKartEkle = new DevExpress.XtraEditors.SimpleButton();
            btnAra = new DevExpress.XtraEditors.SimpleButton();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            BitisTarihi = new DevExpress.XtraEditors.LabelControl();
            BaslangıcTarihi = new DevExpress.XtraEditors.LabelControl();
            txtStokAra = new TextBox();
            StokAra = new DevExpress.XtraEditors.LabelControl();
            cmbxStokSec = new ComboBox();
            StokSec = new DevExpress.XtraEditors.LabelControl();
            gridStokTakibi = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridStokTakibi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Location = new Point(3, 0);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(btnKartEkle);
            splitContainerControl1.Panel1.Controls.Add(btnAra);
            splitContainerControl1.Panel1.Controls.Add(dateTimePicker2);
            splitContainerControl1.Panel1.Controls.Add(dateTimePicker1);
            splitContainerControl1.Panel1.Controls.Add(BitisTarihi);
            splitContainerControl1.Panel1.Controls.Add(BaslangıcTarihi);
            splitContainerControl1.Panel1.Controls.Add(txtStokAra);
            splitContainerControl1.Panel1.Controls.Add(StokAra);
            splitContainerControl1.Panel1.Controls.Add(cmbxStokSec);
            splitContainerControl1.Panel1.Controls.Add(StokSec);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(gridStokTakibi);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(858, 501);
            splitContainerControl1.SplitterPosition = 270;
            splitContainerControl1.TabIndex = 0;
            // 
            // btnKartEkle
            // 
            btnKartEkle.Appearance.BackColor = Color.DarkGray;
            btnKartEkle.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKartEkle.Appearance.ForeColor = Color.Black;
            btnKartEkle.Appearance.Options.UseBackColor = true;
            btnKartEkle.Appearance.Options.UseFont = true;
            btnKartEkle.Appearance.Options.UseForeColor = true;
            btnKartEkle.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnKartEkle.ImageOptions.SvgImage");
            btnKartEkle.Location = new Point(31, 282);
            btnKartEkle.Name = "btnKartEkle";
            btnKartEkle.Size = new Size(113, 49);
            btnKartEkle.TabIndex = 9;
            btnKartEkle.Text = "Kart Ekle";
            btnKartEkle.Click += btnKartEkle_Click;
            // 
            // btnAra
            // 
            btnAra.Appearance.BackColor = Color.FromArgb(255, 128, 0);
            btnAra.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAra.Appearance.ForeColor = Color.Black;
            btnAra.Appearance.Options.UseBackColor = true;
            btnAra.Appearance.Options.UseFont = true;
            btnAra.Appearance.Options.UseForeColor = true;
            btnAra.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            btnAra.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAra.ImageOptions.SvgImage");
            btnAra.Location = new Point(150, 283);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(113, 48);
            btnAra.TabIndex = 8;
            btnAra.Text = "Ara";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(20, 243);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(169, 21);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(20, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(169, 21);
            dateTimePicker1.TabIndex = 6;
            // 
            // BitisTarihi
            // 
            BitisTarihi.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BitisTarihi.Appearance.Options.UseFont = true;
            BitisTarihi.Location = new Point(20, 216);
            BitisTarihi.Name = "BitisTarihi";
            BitisTarihi.Size = new Size(75, 21);
            BitisTarihi.TabIndex = 5;
            BitisTarihi.Text = "Bitiş Tarihi";
            // 
            // BaslangıcTarihi
            // 
            BaslangıcTarihi.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BaslangıcTarihi.Appearance.Options.UseFont = true;
            BaslangıcTarihi.Location = new Point(20, 151);
            BaslangıcTarihi.Name = "BaslangıcTarihi";
            BaslangıcTarihi.Size = new Size(112, 21);
            BaslangıcTarihi.TabIndex = 4;
            BaslangıcTarihi.Text = "Başlangıç Tarihi";
            // 
            // txtStokAra
            // 
            txtStokAra.Location = new Point(20, 93);
            txtStokAra.Name = "txtStokAra";
            txtStokAra.Size = new Size(133, 21);
            txtStokAra.TabIndex = 3;
            // 
            // StokAra
            // 
            StokAra.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StokAra.Appearance.Options.UseFont = true;
            StokAra.Location = new Point(20, 66);
            StokAra.Name = "StokAra";
            StokAra.Size = new Size(62, 21);
            StokAra.TabIndex = 2;
            StokAra.Text = "Stok Ara";
            // 
            // cmbxStokSec
            // 
            cmbxStokSec.FormattingEnabled = true;
            cmbxStokSec.Location = new Point(19, 39);
            cmbxStokSec.Name = "cmbxStokSec";
            cmbxStokSec.Size = new Size(134, 21);
            cmbxStokSec.TabIndex = 1;
            // 
            // StokSec
            // 
            StokSec.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StokSec.Appearance.Options.UseFont = true;
            StokSec.Location = new Point(19, 12);
            StokSec.Name = "StokSec";
            StokSec.Size = new Size(63, 21);
            StokSec.TabIndex = 0;
            StokSec.Text = "Stok Seç";
            // 
            // gridStokTakibi
            // 
            gridStokTakibi.Location = new Point(-6, 0);
            gridStokTakibi.MainView = gridView1;
            gridStokTakibi.Name = "gridStokTakibi";
            gridStokTakibi.Size = new Size(575, 498);
            gridStokTakibi.TabIndex = 0;
            gridStokTakibi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
           
            // 
            // gridView1
            // 
            gridView1.GridControl = gridStokTakibi;
            gridView1.Name = "gridView1";
            // 
            // frmStokTakibi
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 497);
            Controls.Add(splitContainerControl1);
            Name = "frmStokTakibi";
            Text = "Stok Takibi";
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridStokTakibi).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl StokSec;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.LabelControl BitisTarihi;
        private DevExpress.XtraEditors.LabelControl BaslangıcTarihi;
        private TextBox txtStokAra;
        private DevExpress.XtraEditors.LabelControl StokAra;
        private ComboBox cmbxStokSec;
        private DevExpress.XtraEditors.SimpleButton btnKartEkle;
        private DevExpress.XtraGrid.GridControl gridStokTakibi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}