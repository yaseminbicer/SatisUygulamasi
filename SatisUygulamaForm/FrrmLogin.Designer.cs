namespace SatisUygulamaForm
{
    partial class LoginPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnLogin = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(186, 79);
            label1.Name = "label1";
            label1.Size = new Size(346, 48);
            label1.TabIndex = 1;
            label1.Text = "Cosmos Sales";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(366, 127);
            label3.Name = "label3";
            label3.Size = new Size(213, 33);
            label3.TabIndex = 3;
            label3.Text = "Hızlı Satış Sistemi";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(157, 177);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı:";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(227, 205);
            label4.Name = "label4";
            label4.Size = new Size(58, 28);
            label4.TabIndex = 5;
            label4.Text = "Şifre:";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(291, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(291, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 27);
            textBox2.TabIndex = 7;
            textBox2.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(169, 187, 245);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(326, 243);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 45);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.AppWorkspace;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(37, 291);
            label5.Name = "label5";
            label5.Size = new Size(240, 25);
            label5.TabIndex = 9;
            label5.Text = "Kullanıcı Adı veya Şifre hatalı!";
            label5.Visible = false;
            // 
            // LoginPanel
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(631, 319);
            Controls.Add(label5);
            Controls.Add(btnLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLogin;
        private Label label5;
    }
}