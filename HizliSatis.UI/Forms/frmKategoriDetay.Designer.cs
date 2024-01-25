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
            lblKategoriTanimi = new Label();
            panel1 = new Panel();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            gridItems = new DevExpress.XtraGrid.GridControl();
            viewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            colBacode = new DevExpress.XtraGrid.Columns.GridColumn();
            colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit1).BeginInit();
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
            btnIptal.Location = new Point(511, 478);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(109, 37);
            btnIptal.TabIndex = 6;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            btnKaydet.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseBackColor = true;
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.AppearanceDisabled.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.AppearanceDisabled.Options.UseFont = true;
            btnKaydet.Location = new Point(626, 478);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(109, 37);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            // 
            // lblKategoriTanimi
            // 
            lblKategoriTanimi.AutoSize = true;
            lblKategoriTanimi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblKategoriTanimi.Location = new Point(12, 18);
            lblKategoriTanimi.Name = "lblKategoriTanimi";
            lblKategoriTanimi.Size = new Size(143, 25);
            lblKategoriTanimi.TabIndex = 8;
            lblKategoriTanimi.Text = "Kategori Tanımı";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(161, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 1);
            panel1.TabIndex = 79;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(161, 15);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(328, 28);
            textEdit1.TabIndex = 80;
            // 
            // gridItems
            // 
            gridItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridItems.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridItems.Location = new Point(12, 73);
            gridItems.MainView = viewItems;
            gridItems.Margin = new Padding(3, 2, 3, 2);
            gridItems.Name = "gridItems";
            gridItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemMemoEdit1 });
            gridItems.Size = new Size(751, 386);
            gridItems.TabIndex = 82;
            gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { viewItems });
            // 
            // viewItems
            // 
            viewItems.Appearance.HeaderPanel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            viewItems.Appearance.HeaderPanel.Options.UseFont = true;
            viewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colProductName, colBacode, colPrice });
            viewItems.GridControl = gridItems;
            viewItems.Name = "viewItems";
            viewItems.OptionsView.EnableAppearanceEvenRow = true;
            viewItems.OptionsView.ShowGroupPanel = false;
            viewItems.OptionsView.ShowIndicator = false;
            // 
            // colProductName
            // 
            colProductName.Caption = "Stok Adı";
            colProductName.FieldName = "ProductName";
            colProductName.Name = "colProductName";
            colProductName.OptionsColumn.AllowEdit = false;
            colProductName.Visible = true;
            colProductName.VisibleIndex = 0;
            colProductName.Width = 252;
            // 
            // colBacode
            // 
            colBacode.Caption = "Barkod";
            colBacode.FieldName = "Barcode";
            colBacode.Name = "colBacode";
            colBacode.OptionsColumn.AllowEdit = false;
            colBacode.Visible = true;
            colBacode.VisibleIndex = 1;
            colBacode.Width = 149;
            // 
            // colPrice
            // 
            colPrice.AppearanceCell.Options.UseTextOptions = true;
            colPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colPrice.AppearanceHeader.Options.UseTextOptions = true;
            colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colPrice.Caption = "Fiyat";
            colPrice.FieldName = "Price";
            colPrice.Name = "colPrice";
            colPrice.OptionsColumn.AllowEdit = false;
            colPrice.Visible = true;
            colPrice.VisibleIndex = 2;
            colPrice.Width = 100;
            // 
            // repositoryItemMemoEdit1
            // 
            repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // frmKategoriDetay
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnIptal;
            ClientSize = new Size(775, 527);
            Controls.Add(gridItems);
            Controls.Add(textEdit1);
            Controls.Add(panel1);
            Controls.Add(lblKategoriTanimi);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            Name = "frmKategoriDetay";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private Label lblKategoriTanimi;
        private Panel panel1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl gridItems;
        private DevExpress.XtraGrid.Views.Grid.GridView viewItems;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colBacode;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}