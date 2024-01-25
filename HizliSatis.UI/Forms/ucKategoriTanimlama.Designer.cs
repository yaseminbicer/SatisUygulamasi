namespace HizliSatis.UI.Forms
{
    partial class ucKategoriTanimlama
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
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnEkle = new DevExpress.XtraEditors.SimpleButton();
            gridCategory = new DevExpress.XtraGrid.GridControl();
            ViewCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            searchControl1 = new DevExpress.XtraEditors.SearchControl();
            btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchControl1.Properties).BeginInit();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.Appearance.BackColor = Color.FromArgb(67, 85, 167);
            btnSil.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.Appearance.Options.UseBackColor = true;
            btnSil.Appearance.Options.UseFont = true;
            btnSil.AppearanceDisabled.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.AppearanceDisabled.Options.UseFont = true;
            btnSil.Location = new Point(581, 47);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(109, 37);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            // 
            // btnEkle
            // 
            btnEkle.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            btnEkle.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Appearance.Options.UseBackColor = true;
            btnEkle.Appearance.Options.UseFont = true;
            btnEkle.AppearanceDisabled.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.AppearanceDisabled.Options.UseFont = true;
            btnEkle.Location = new Point(696, 47);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(109, 37);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            // 
            // gridCategory
            // 
            gridCategory.Dock = DockStyle.Bottom;
            gridCategory.Location = new Point(0, 119);
            gridCategory.MainView = ViewCategory;
            gridCategory.Name = "gridCategory";
            gridCategory.Size = new Size(814, 501);
            gridCategory.TabIndex = 6;
            gridCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { ViewCategory });
            // 
            // ViewCategory
            // 
            ViewCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1 });
            ViewCategory.GridControl = gridCategory;
            ViewCategory.Name = "ViewCategory";
            ViewCategory.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Kategori";
            gridColumn1.MinWidth = 23;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 85;
            // 
            // searchControl1
            // 
            searchControl1.Location = new Point(3, 56);
            searchControl1.Name = "searchControl1";
            searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Repository.ClearButton(), new DevExpress.XtraEditors.Repository.SearchButton() });
            searchControl1.Size = new Size(442, 28);
            searchControl1.TabIndex = 7;
            // 
            // btnDuzenle
            // 
            btnDuzenle.ImageOptions.Image = Properties.Resources.edit_svgrepo_com;
            btnDuzenle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            btnDuzenle.Location = new Point(540, 47);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(35, 37);
            btnDuzenle.TabIndex = 8;
            // 
            // ucKategoriTanimlama
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDuzenle);
            Controls.Add(searchControl1);
            Controls.Add(gridCategory);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Name = "ucKategoriTanimlama";
            Size = new Size(814, 620);
            ((System.ComponentModel.ISupportInitialize)gridCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchControl1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraGrid.GridControl gridCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
    }
}
