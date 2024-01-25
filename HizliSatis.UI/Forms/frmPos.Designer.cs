namespace HizliSatis.UI.Forms
{
    partial class frmPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPos));
            htmlContentControl1 = new DevExpress.XtraEditors.HtmlContentControl();
            panel1 = new Panel();
            panel2 = new Panel();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)htmlContentControl1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // htmlContentControl1
            // 
            htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles");
            htmlContentControl1.HtmlTemplate.Template = resources.GetString("htmlContentControl1.HtmlTemplate.Template");
            htmlContentControl1.Location = new Point(3, 12);
            htmlContentControl1.Name = "htmlContentControl1";
            htmlContentControl1.Size = new Size(185, 61);
            htmlContentControl1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelControl8);
            panel1.Controls.Add(labelControl7);
            panel1.Controls.Add(labelControl6);
            panel1.Controls.Add(labelControl3);
            panel1.Controls.Add(labelControl2);
            panel1.Controls.Add(labelControl1);
            panel1.Controls.Add(gridControl1);
            panel1.Controls.Add(htmlContentControl1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 806);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(649, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 806);
            panel2.TabIndex = 2;
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(3, 79);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(640, 727);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(3, 79);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(30, 30);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "No\r\n";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(39, 84);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(359, 19);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Ürün";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            labelControl3.Location = new Point(437, 81);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(50, 26);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Miktar";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl6.Location = new Point(596, 81);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(44, 26);
            labelControl6.TabIndex = 7;
            labelControl6.Text = "Fiyat";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl7.Location = new Point(540, 81);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(50, 26);
            labelControl7.TabIndex = 8;
            labelControl7.Text = "İndirim";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl8.Location = new Point(493, 81);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(41, 26);
            labelControl8.TabIndex = 9;
            labelControl8.Text = "KDV";
            // 
            // frmPos
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 806);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmPos";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)htmlContentControl1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl1;
        private Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}