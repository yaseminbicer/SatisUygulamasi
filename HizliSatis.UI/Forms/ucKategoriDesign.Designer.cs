namespace HizliSatis.UI.Forms
{
    partial class ucKategoriDesign
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            gridKategori = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colPluProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            colPluPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colPluImage = new DevExpress.XtraGrid.Columns.GridColumn();
            colPluEmptyImage = new DevExpress.XtraGrid.Columns.GridColumn();
            tileView = new DevExpress.XtraGrid.Views.Tile.TileView();
            colPluUrunAdi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colPluFiyat = new DevExpress.XtraGrid.Columns.TileViewColumn();
            Resim = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colPluBosResim = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)gridKategori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tileView).BeginInit();
            SuspendLayout();
            // 
            // gridKategori
            // 
            gridKategori.Dock = DockStyle.Fill;
            gridKategori.Location = new Point(0, 0);
            gridKategori.MainView = tileView;
            gridKategori.Name = "gridKategori";
            gridKategori.Size = new Size(294, 661);
            gridKategori.TabIndex = 0;
            gridKategori.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1, tileView });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colPluProductName, colPluPrice, colPluImage, colPluEmptyImage });
            gridView1.GridControl = gridKategori;
            gridView1.Name = "gridView1";
            // 
            // colPluProductName
            // 
            colPluProductName.Caption = "Başlık";
            colPluProductName.FieldName = "PluNAme";
            colPluProductName.Name = "colPluProductName";
            colPluProductName.Visible = true;
            colPluProductName.VisibleIndex = 0;
            // 
            // colPluPrice
            // 
            colPluPrice.Caption = "Fiyat";
            colPluPrice.FieldName = "PluPrice";
            colPluPrice.Name = "colPluPrice";
            colPluPrice.Visible = true;
            colPluPrice.VisibleIndex = 1;
            // 
            // colPluImage
            // 
            colPluImage.Caption = "Resim";
            colPluImage.FieldName = "PluImage";
            colPluImage.Name = "colPluImage";
            colPluImage.Visible = true;
            colPluImage.VisibleIndex = 2;
            // 
            // colPluEmptyImage
            // 
            colPluEmptyImage.Caption = "Boş Resim";
            colPluEmptyImage.FieldName = "PluEmptyImage";
            colPluEmptyImage.Name = "colPluEmptyImage";
            colPluEmptyImage.Visible = true;
            colPluEmptyImage.VisibleIndex = 3;
            // 
            // tileView
            // 
            tileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colPluUrunAdi, colPluFiyat, Resim, colPluBosResim });
            tileView.GridControl = gridKategori;
            tileView.Name = "tileView";
            tileView.OptionsTiles.IndentBetweenGroups = 55;
            tileView.OptionsTiles.IndentBetweenItems = 1;
            tileView.OptionsTiles.ItemPadding = new Padding(1);
            tileView.OptionsTiles.ItemSize = new Size(90, 105);
            tileView.OptionsTiles.Orientation = Orientation.Vertical;
            tileView.OptionsTiles.Padding = new Padding(3);
            tileView.TileColumns.Add(tableColumnDefinition1);
            tileView.TileRows.Add(tableRowDefinition1);
            tileView.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.StretchHorizontal = true;
            tileViewItemElement1.StretchVertical = true;
            tileViewItemElement1.Text = "Resim";
            tileViewItemElement2.Column = colPluUrunAdi;
            tileViewItemElement2.Height = 35;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.StretchHorizontal = true;
            tileViewItemElement2.StretchVertical = true;
            tileViewItemElement2.Text = "colPluUrunAdi";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileViewItemElement2.Width = 90;
            tileView.TileTemplate.Add(tileViewItemElement1);
            tileView.TileTemplate.Add(tileViewItemElement2);
            // 
            // colPluUrunAdi
            // 
            colPluUrunAdi.Caption = "Başlık";
            colPluUrunAdi.FieldName = "PluName";
            colPluUrunAdi.Name = "colPluUrunAdi";
            colPluUrunAdi.Visible = true;
            colPluUrunAdi.VisibleIndex = 0;
            // 
            // colPluFiyat
            // 
            colPluFiyat.Caption = "Fiyat";
            colPluFiyat.FieldName = "PluFiyat";
            colPluFiyat.Name = "colPluFiyat";
            colPluFiyat.Visible = true;
            colPluFiyat.VisibleIndex = 1;
            // 
            // Resim
            // 
            Resim.Caption = "Resim";
            Resim.FieldName = "PluResim";
            Resim.Name = "Resim";
            Resim.Visible = true;
            Resim.VisibleIndex = 2;
            // 
            // colPluBosResim
            // 
            colPluBosResim.Caption = "Boş Resim";
            colPluBosResim.FieldName = "BosResim";
            colPluBosResim.Name = "colPluBosResim";
            colPluBosResim.Visible = true;
            colPluBosResim.VisibleIndex = 3;
            // 
            // ucKategori
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridKategori);
            Name = "ucKategori";
            Size = new Size(294, 661);
            ((System.ComponentModel.ISupportInitialize)gridKategori).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tileView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridKategori;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPluProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colPluPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPluImage;
        private DevExpress.XtraGrid.Columns.GridColumn colPluEmptyImage;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView;
        private DevExpress.XtraGrid.Columns.TileViewColumn colPluUrunAdi;
        private DevExpress.XtraGrid.Columns.TileViewColumn colPluFiyat;
        private DevExpress.XtraGrid.Columns.TileViewColumn Resim;
        private DevExpress.XtraGrid.Columns.TileViewColumn colPluBosResim;
    }
}
