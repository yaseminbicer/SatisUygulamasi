namespace SatisUygulamaForm
{
    partial class frmIslemSecme
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btnKullaniciDegistir = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 23);
            label1.TabIndex = 5;
            label1.Text = "Cosmos Sales";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(169, 187, 245);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(30, 50);
            button1.Name = "button1";
            button1.Size = new Size(160, 88);
            button1.TabIndex = 0;
            button1.Text = "Satış İşlemi";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(168, 106, 91);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(30, 140);
            button2.Name = "button2";
            button2.Size = new Size(160, 88);
            button2.TabIndex = 6;
            button2.Text = "Fiyatı Güncelle";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(245, 145, 120);
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(196, 50);
            button3.Name = "button3";
            button3.Size = new Size(160, 88);
            button3.TabIndex = 7;
            button3.Text = "Stok Takibi";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(130, 168, 82);
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(196, 140);
            button4.Name = "button4";
            button4.Size = new Size(160, 88);
            button4.TabIndex = 8;
            button4.Text = "Ürün Ekle";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(168, 106, 91);
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(362, 50);
            button5.Name = "button5";
            button5.Size = new Size(160, 88);
            button5.TabIndex = 9;
            button5.Text = "Ayarlar";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnKullaniciDegistir
            // 
            btnKullaniciDegistir.BackColor = Color.FromArgb(225, 185, 95);
            btnKullaniciDegistir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKullaniciDegistir.ForeColor = Color.White;
            btnKullaniciDegistir.Location = new Point(362, 140);
            btnKullaniciDegistir.Name = "btnKullaniciDegistir";
            btnKullaniciDegistir.Size = new Size(82, 88);
            btnKullaniciDegistir.TabIndex = 10;
            btnKullaniciDegistir.Text = "Kullanıcı Değiştir";
            btnKullaniciDegistir.UseVisualStyleBackColor = false;
            btnKullaniciDegistir.Click += btnKullaniciDegistir_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(250, 74, 59);
            btnCikis.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(450, 140);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(72, 88);
            btnCikis.TabIndex = 11;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // frmIslemSecme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(547, 250);
            Controls.Add(btnCikis);
            Controls.Add(btnKullaniciDegistir);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmIslemSecme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İşlemler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnKullaniciDegistir;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btnCikis;
    }
}