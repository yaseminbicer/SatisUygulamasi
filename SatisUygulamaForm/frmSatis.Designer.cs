namespace SatisUygulamaForm
{
    partial class frmSatis
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            Ara = new Button();
            tBarkod = new TextBox();
            tMiktar = new TextBox();
            label1 = new Label();
            Barkod = new Label();
            GridSatisListesi = new DataGridView();
            Barkd = new DataGridViewTextBoxColumn();
            UrunAdi = new DataGridViewTextBoxColumn();
            br = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Birimi = new DataGridViewTextBoxColumn();
            toplam = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            button15 = new Button();
            textBox5 = new TextBox();
            beks = new Button();
            bart = new Button();
            bent = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            bv = new Button();
            b3 = new Button();
            button3 = new Button();
            b2 = new Button();
            b1 = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridSatisListesi).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint_1;
            splitContainer1.Size = new Size(1117, 618);
            splitContainer1.SplitterDistance = 491;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(GridSatisListesi, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 196F));
            tableLayoutPanel1.Size = new Size(491, 618);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_2;
            // 
            // panel1
            // 
            panel1.Controls.Add(Ara);
            panel1.Controls.Add(tBarkod);
            panel1.Controls.Add(tMiktar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Barkod);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 72);
            panel1.TabIndex = 0;
            // 
            // Ara
            // 
            Ara.Location = new Point(312, 40);
            Ara.Margin = new Padding(3, 2, 3, 2);
            Ara.Name = "Ara";
            Ara.Size = new Size(54, 30);
            Ara.TabIndex = 3;
            Ara.Text = "Ara";
            Ara.UseVisualStyleBackColor = true;
            Ara.Click += Ara_Click;
            // 
            // tBarkod
            // 
            tBarkod.Location = new Point(97, 45);
            tBarkod.Name = "tBarkod";
            tBarkod.Size = new Size(202, 23);
            tBarkod.TabIndex = 2;
            tBarkod.TextChanged += tBarkod_TextChanged;
            // 
            // tMiktar
            // 
            tMiktar.Location = new Point(27, 45);
            tMiktar.Name = "tMiktar";
            tMiktar.Size = new Size(64, 23);
            tMiktar.TabIndex = 1;
            tMiktar.TextChanged += tMiktar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 21);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Miktar";
            // 
            // Barkod
            // 
            Barkod.AutoSize = true;
            Barkod.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Barkod.Location = new Point(97, 21);
            Barkod.Name = "Barkod";
            Barkod.Size = new Size(62, 21);
            Barkod.TabIndex = 0;
            Barkod.Text = "Barkod";
            Barkod.Click += Barkod_Click;
            // 
            // GridSatisListesi
            // 
            GridSatisListesi.AllowUserToAddRows = false;
            GridSatisListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridSatisListesi.BackgroundColor = Color.Silver;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridSatisListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridSatisListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridSatisListesi.Columns.AddRange(new DataGridViewColumn[] { Barkd, UrunAdi, br, Miktar, Birimi, toplam });
            GridSatisListesi.Dock = DockStyle.Fill;
            GridSatisListesi.EnableHeadersVisualStyles = false;
            GridSatisListesi.Location = new Point(3, 81);
            GridSatisListesi.Name = "GridSatisListesi";
            GridSatisListesi.RowHeadersVisible = false;
            GridSatisListesi.RowHeadersWidth = 51;
            GridSatisListesi.RowTemplate.Height = 25;
            GridSatisListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridSatisListesi.Size = new Size(485, 338);
            GridSatisListesi.TabIndex = 1;
            GridSatisListesi.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Barkd
            // 
            Barkd.HeaderText = "Barkod";
            Barkd.MinimumWidth = 6;
            Barkd.Name = "Barkd";
            // 
            // UrunAdi
            // 
            UrunAdi.HeaderText = "Ürün Adı";
            UrunAdi.MinimumWidth = 6;
            UrunAdi.Name = "UrunAdi";
            // 
            // br
            // 
            br.HeaderText = "Br Fiyat";
            br.MinimumWidth = 6;
            br.Name = "br";
            // 
            // Miktar
            // 
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 6;
            Miktar.Name = "Miktar";
            // 
            // Birimi
            // 
            Birimi.HeaderText = "Birimi";
            Birimi.MinimumWidth = 6;
            Birimi.Name = "Birimi";
            // 
            // toplam
            // 
            toplam.HeaderText = "Genel Toplam";
            toplam.MinimumWidth = 6;
            toplam.Name = "toplam";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.42268F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.57732F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 425);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(485, 190);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(button15);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(beks);
            panel2.Controls.Add(bart);
            panel2.Controls.Add(bent);
            panel2.Controls.Add(b7);
            panel2.Controls.Add(b8);
            panel2.Controls.Add(b9);
            panel2.Controls.Add(b4);
            panel2.Controls.Add(b5);
            panel2.Controls.Add(b6);
            panel2.Controls.Add(bv);
            panel2.Controls.Add(b3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(b2);
            panel2.Controls.Add(b1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 176);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // button15
            // 
            button15.BackgroundImage = (Image)resources.GetObject("button15.BackgroundImage");
            button15.BackgroundImageLayout = ImageLayout.Stretch;
            button15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(157, 3);
            button15.Margin = new Padding(1);
            button15.Name = "button15";
            button15.Size = new Size(46, 33);
            button15.TabIndex = 15;
            button15.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(13, 3);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(144, 33);
            textBox5.TabIndex = 14;
            // 
            // beks
            // 
            beks.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            beks.Location = new Point(157, 37);
            beks.Margin = new Padding(1);
            beks.Name = "beks";
            beks.Size = new Size(46, 33);
            beks.TabIndex = 11;
            beks.Text = "-";
            beks.UseVisualStyleBackColor = true;
            // 
            // bart
            // 
            bart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bart.Location = new Point(157, 72);
            bart.Margin = new Padding(1);
            bart.Name = "bart";
            bart.Size = new Size(46, 33);
            bart.TabIndex = 1;
            bart.Text = "+";
            bart.UseVisualStyleBackColor = true;
            // 
            // bent
            // 
            bent.BackgroundImage = (Image)resources.GetObject("bent.BackgroundImage");
            bent.BackgroundImageLayout = ImageLayout.Zoom;
            bent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bent.Location = new Point(157, 107);
            bent.Margin = new Padding(1);
            bent.Name = "bent";
            bent.Size = new Size(46, 68);
            bent.TabIndex = 10;
            bent.UseVisualStyleBackColor = true;
            // 
            // b7
            // 
            b7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b7.Location = new Point(13, 37);
            b7.Margin = new Padding(1);
            b7.Name = "b7";
            b7.Size = new Size(46, 33);
            b7.TabIndex = 9;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            // 
            // b8
            // 
            b8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b8.Location = new Point(61, 37);
            b8.Margin = new Padding(1);
            b8.Name = "b8";
            b8.Size = new Size(46, 33);
            b8.TabIndex = 8;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            // 
            // b9
            // 
            b9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b9.Location = new Point(109, 37);
            b9.Margin = new Padding(1);
            b9.Name = "b9";
            b9.Size = new Size(46, 33);
            b9.TabIndex = 7;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            b4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b4.Location = new Point(13, 72);
            b4.Margin = new Padding(1);
            b4.Name = "b4";
            b4.Size = new Size(46, 33);
            b4.TabIndex = 6;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            // 
            // b5
            // 
            b5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b5.Location = new Point(61, 72);
            b5.Margin = new Padding(1);
            b5.Name = "b5";
            b5.Size = new Size(46, 33);
            b5.TabIndex = 5;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            // 
            // b6
            // 
            b6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b6.Location = new Point(109, 72);
            b6.Margin = new Padding(1);
            b6.Name = "b6";
            b6.Size = new Size(46, 33);
            b6.TabIndex = 4;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            // 
            // bv
            // 
            bv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bv.Location = new Point(109, 142);
            bv.Margin = new Padding(1);
            bv.Name = "bv";
            bv.Size = new Size(46, 33);
            bv.TabIndex = 3;
            bv.Text = ",";
            bv.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b3.Location = new Point(109, 107);
            b3.Margin = new Padding(1);
            b3.Name = "b3";
            b3.Size = new Size(46, 33);
            b3.TabIndex = 3;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(11, 142);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(98, 33);
            button3.TabIndex = 2;
            button3.Text = "0";
            button3.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(61, 107);
            b2.Margin = new Padding(1);
            b2.Name = "b2";
            b2.Size = new Size(46, 33);
            b2.TabIndex = 1;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b1.Location = new Point(13, 107);
            b1.Margin = new Padding(1);
            b1.Name = "b1";
            b1.Size = new Size(46, 33);
            b1.TabIndex = 0;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 177);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 146);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // frmSatis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 618);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSatis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridSatisListesi).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label Barkod;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private TextBox tBarkod;
        private TextBox tMiktar;
        private DataGridView GridSatisListesi;
        private DataGridViewTextBoxColumn Barkd;
        private DataGridViewTextBoxColumn UrunAdi;
        private DataGridViewTextBoxColumn br;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn toplam;
        private TableLayoutPanel tableLayoutPanel2;
        private Button bart;
        private Panel panel2;
        private Button bent;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button bv;
        private Button b3;
        private Button button3;
        private Button b2;
        private Button b1;
        private Button beks;
        private Button button15;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn Birimi;
        private Button Ara;
    }
}