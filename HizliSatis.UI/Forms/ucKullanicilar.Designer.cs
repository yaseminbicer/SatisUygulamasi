namespace HizliSatis.UI.Forms
{
    partial class ucKullanicilar
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
            gridKullanici = new DevExpress.XtraGrid.GridControl();
            viewKullanici = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridKullanici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewKullanici).BeginInit();
            SuspendLayout();
            // 
            // gridKullanici
            // 
            gridKullanici.Location = new Point(0, 128);
            gridKullanici.MainView = viewKullanici;
            gridKullanici.Name = "gridKullanici";
            gridKullanici.Size = new Size(814, 620);
            gridKullanici.TabIndex = 1;
            gridKullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { viewKullanici });
            // 
            // viewKullanici
            // 
            viewKullanici.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4 });
            viewKullanici.GridControl = gridKullanici;
            viewKullanici.Name = "viewKullanici";
            viewKullanici.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            viewKullanici.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            viewKullanici.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Kullanıcı Adı";
            gridColumn1.FieldName = "KullaniciAdi";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Şifre";
            gridColumn2.FieldName = "Sifre";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.OptionsEditForm.StartNewRow = true;
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Ad Soyad";
            gridColumn3.FieldName = "AdSoyad";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.OptionsEditForm.StartNewRow = true;
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Yönetici";
            gridColumn4.FieldName = "Yonetici";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.OptionsEditForm.StartNewRow = true;
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            // 
            // btnSil
            // 
            btnSil.Appearance.BackColor = Color.FromArgb(67, 85, 167);
            btnSil.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.Appearance.Options.UseBackColor = true;
            btnSil.Appearance.Options.UseFont = true;
            btnSil.AppearanceDisabled.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.AppearanceDisabled.Options.UseFont = true;
            btnSil.Location = new Point(577, 51);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(109, 37);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            btnKaydet.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseBackColor = true;
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.AppearanceDisabled.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.AppearanceDisabled.Options.UseFont = true;
            btnKaydet.Location = new Point(692, 51);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(109, 37);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            // 
            // ucKullanicilar
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(gridKullanici);
            Name = "ucKullanicilar";
            Size = new Size(814, 751);
            ((System.ComponentModel.ISupportInitialize)gridKullanici).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewKullanici).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridKullanici;
        private DevExpress.XtraGrid.Views.Grid.GridView viewKullanici;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}
