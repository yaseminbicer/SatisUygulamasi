namespace HizliSatis.UI.Forms
{
    partial class frmMusteriler
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
            gridMusteri = new DevExpress.XtraGrid.GridControl();
            viewMusteri = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            btnIptal = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridMusteri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewMusteri).BeginInit();
            SuspendLayout();
            // 
            // gridMusteri
            // 
            gridMusteri.Location = new Point(3, 41);
            gridMusteri.MainView = viewMusteri;
            gridMusteri.Name = "gridMusteri";
            gridMusteri.Size = new Size(674, 387);
            gridMusteri.TabIndex = 0;
            gridMusteri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { viewMusteri });
            // 
            // viewMusteri
            // 
            viewMusteri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5 });
            viewMusteri.GridControl = gridMusteri;
            viewMusteri.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "") });
            viewMusteri.Name = "viewMusteri";
            viewMusteri.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            viewMusteri.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            viewMusteri.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Ad Soyad";
            gridColumn1.FieldName = "AdSoyad";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Unvan";
            gridColumn2.FieldName = "Unvan";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Adres";
            gridColumn3.FieldName = "Adres";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Telefon";
            gridColumn4.FieldName = "Telefon";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "EPosta";
            gridColumn5.FieldName = "EPosta";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            // 
            // btnSil
            // 
            btnSil.Appearance.BackColor = Color.Red;
            btnSil.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Appearance.Options.UseBackColor = true;
            btnSil.Appearance.Options.UseFont = true;
            btnSil.Location = new Point(461, 8);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(105, 27);
            btnSil.TabIndex = 1;
            btnSil.Text = "SİL";
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.BackColor = Color.FromArgb(0, 192, 0);
            btnKaydet.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseBackColor = true;
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.Location = new Point(350, 8);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(105, 27);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "KAYDET";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Appearance.BackColor = Color.Gray;
            btnIptal.Appearance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIptal.Appearance.Options.UseBackColor = true;
            btnIptal.Appearance.Options.UseFont = true;
            btnIptal.Location = new Point(572, 8);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(105, 27);
            btnIptal.TabIndex = 2;
            btnIptal.Text = "İPTAL";
            btnIptal.Click += btnIptal_Click;
            // 
            // frmMusteriler
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 436);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(btnSil);
            Controls.Add(gridMusteri);
            Name = "frmMusteriler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMusteriler";
            Activated += frmMusteriler_Load;
            ((System.ComponentModel.ISupportInitialize)gridMusteri).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewMusteri).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridMusteri;
        private DevExpress.XtraGrid.Views.Grid.GridView viewMusteri;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
    }
}