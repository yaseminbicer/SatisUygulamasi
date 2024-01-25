namespace HizliSatis.UI.Forms
{
    partial class frmSatisnew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisnew));
            label1 = new Label();
            btnUser = new DevExpress.XtraEditors.DropDownButton();
            btnNotification = new DevExpress.XtraEditors.SimpleButton();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btnAyarlar = new Button();
            btnTuslar = new Button();
            pictureBox1 = new PictureBox();
            btnTemizle = new Button();
            btnUrunSil = new Button();
            btnFis = new Button();
            btnIndirim = new Button();
            btnIkram = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(113, 153);
            label1.Name = "label1";
            label1.Size = new Size(108, 33);
            label1.TabIndex = 22;
            label1.Text = "Hızlı Satış";
            // 
            // btnUser
            // 
            btnUser.Appearance.BackColor = Color.FromArgb(140, 165, 224);
            btnUser.Appearance.Options.UseBackColor = true;
            btnUser.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            btnUser.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnUser.ImageOptions.Image = (Image)resources.GetObject("btnUser.ImageOptions.Image");
            btnUser.ImageOptions.ImageIndex = 54;
            btnUser.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnUser.ImageOptions.SvgImageSize = new Size(30, 30);
            btnUser.Location = new Point(404, 309);
            btnUser.LookAndFeel.SkinName = "WXI";
            btnUser.LookAndFeel.UseDefaultLookAndFeel = false;
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(40, 40);
            btnUser.TabIndex = 8;
            // 
            // btnNotification
            // 
            btnNotification.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNotification.Appearance.BackColor = Color.FromArgb(140, 165, 224);
            btnNotification.Appearance.Options.UseBackColor = true;
            btnNotification.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnNotification.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnNotification.ImageOptions.SvgImage");
            btnNotification.ImageOptions.SvgImageSize = new Size(24, 24);
            btnNotification.Location = new Point(61, 268);
            btnNotification.LookAndFeel.SkinName = "WXI";
            btnNotification.LookAndFeel.UseDefaultLookAndFeel = false;
            btnNotification.Margin = new Padding(4);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(55, 50);
            btnNotification.TabIndex = 19;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(140, 165, 233);
            pictureBox2.Image = Properties.Resources.WhatsApp_Image_2024_01_02_at_01_33_50;
            pictureBox2.Location = new Point(83, 369);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(btnAyarlar);
            panel1.Controls.Add(btnTuslar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnTemizle);
            panel1.Controls.Add(btnUrunSil);
            panel1.Controls.Add(btnFis);
            panel1.Controls.Add(btnIndirim);
            panel1.Controls.Add(btnIkram);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 954);
            panel1.TabIndex = 0;
            // 
            // btnAyarlar
            // 
            btnAyarlar.Dock = DockStyle.Bottom;
            btnAyarlar.FlatAppearance.BorderColor = Color.Gray;
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAyarlar.ForeColor = Color.White;
            btnAyarlar.Image = Properties.Resources.settings_svgrepo_com__2_;
            btnAyarlar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyarlar.Location = new Point(0, 774);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(212, 90);
            btnAyarlar.TabIndex = 10;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.TextAlign = ContentAlignment.MiddleLeft;
            btnAyarlar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAyarlar.UseVisualStyleBackColor = true;
            // 
            // btnTuslar
            // 
            btnTuslar.Dock = DockStyle.Bottom;
            btnTuslar.FlatAppearance.BorderColor = Color.Gray;
            btnTuslar.FlatStyle = FlatStyle.Flat;
            btnTuslar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTuslar.ForeColor = Color.White;
            btnTuslar.Image = Properties.Resources.phone_numpad_svgrepo_com__4_;
            btnTuslar.ImageAlign = ContentAlignment.MiddleLeft;
            btnTuslar.Location = new Point(0, 864);
            btnTuslar.Name = "btnTuslar";
            btnTuslar.Size = new Size(212, 90);
            btnTuslar.TabIndex = 9;
            btnTuslar.Text = "Tuşlar";
            btnTuslar.TextAlign = ContentAlignment.MiddleLeft;
            btnTuslar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTuslar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(41, 39, 40);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-20, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnTemizle
            // 
            btnTemizle.Dock = DockStyle.Top;
            btnTemizle.FlatAppearance.BorderColor = Color.Gray;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Image = Properties.Resources.delete_recycle_bin_trash_can_svgrepo_com;
            btnTemizle.ImageAlign = ContentAlignment.MiddleLeft;
            btnTemizle.Location = new Point(0, 474);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(212, 90);
            btnTemizle.TabIndex = 8;
            btnTemizle.Text = "Temizle";
            btnTemizle.TextAlign = ContentAlignment.MiddleLeft;
            btnTemizle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Dock = DockStyle.Top;
            btnUrunSil.FlatAppearance.BorderColor = Color.Gray;
            btnUrunSil.FlatStyle = FlatStyle.Flat;
            btnUrunSil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUrunSil.ForeColor = Color.White;
            btnUrunSil.Image = Properties.Resources.delete_svgrepo_com__2_;
            btnUrunSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnUrunSil.Location = new Point(0, 384);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(212, 90);
            btnUrunSil.TabIndex = 7;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.TextAlign = ContentAlignment.MiddleLeft;
            btnUrunSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrunSil.UseVisualStyleBackColor = true;
            // 
            // btnFis
            // 
            btnFis.Dock = DockStyle.Top;
            btnFis.FlatAppearance.BorderColor = Color.Gray;
            btnFis.FlatStyle = FlatStyle.Flat;
            btnFis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFis.ForeColor = Color.White;
            btnFis.Image = Properties.Resources.bill_svgrepo_com;
            btnFis.ImageAlign = ContentAlignment.MiddleLeft;
            btnFis.Location = new Point(0, 294);
            btnFis.Name = "btnFis";
            btnFis.Size = new Size(212, 90);
            btnFis.TabIndex = 6;
            btnFis.Text = "Fiş";
            btnFis.TextAlign = ContentAlignment.MiddleLeft;
            btnFis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFis.UseVisualStyleBackColor = true;
            // 
            // btnIndirim
            // 
            btnIndirim.Dock = DockStyle.Top;
            btnIndirim.FlatAppearance.BorderColor = Color.Gray;
            btnIndirim.FlatStyle = FlatStyle.Flat;
            btnIndirim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIndirim.ForeColor = Color.White;
            btnIndirim.Image = Properties.Resources.discount_svgrepo_com;
            btnIndirim.ImageAlign = ContentAlignment.MiddleLeft;
            btnIndirim.Location = new Point(0, 204);
            btnIndirim.Name = "btnIndirim";
            btnIndirim.Size = new Size(212, 90);
            btnIndirim.TabIndex = 5;
            btnIndirim.Text = "İndirim";
            btnIndirim.TextAlign = ContentAlignment.MiddleLeft;
            btnIndirim.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIndirim.UseVisualStyleBackColor = true;
            // 
            // btnIkram
            // 
            btnIkram.Dock = DockStyle.Top;
            btnIkram.FlatAppearance.BorderColor = Color.Gray;
            btnIkram.FlatStyle = FlatStyle.Flat;
            btnIkram.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIkram.ForeColor = Color.White;
            btnIkram.Image = Properties.Resources.gift_svgrepo_com__1_;
            btnIkram.ImageAlign = ContentAlignment.MiddleLeft;
            btnIkram.Location = new Point(0, 114);
            btnIkram.Name = "btnIkram";
            btnIkram.Size = new Size(212, 90);
            btnIkram.TabIndex = 4;
            btnIkram.Text = "İkram";
            btnIkram.TextAlign = ContentAlignment.MiddleLeft;
            btnIkram.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIkram.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(212, 114);
            button1.TabIndex = 3;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(41, 39, 40);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(212, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 114);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(212, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(979, 840);
            panel3.TabIndex = 2;
            // 
            // frmSatisnew
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 954);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSatisnew";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnNotification;
        private PictureBox pictureBox2;
        private DevExpress.XtraEditors.DropDownButton btnUser;
        private Label label1;
        private Extra.SideBar sideBar1;
        private Panel panel1;
        private Button btnTemizle;
        private Button btnUrunSil;
        private Button btnFis;
        private Button btnIndirim;
        private Button btnIkram;
        private Button button1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnAyarlar;
        private Button btnTuslar;
        private Panel panel3;
    }
}