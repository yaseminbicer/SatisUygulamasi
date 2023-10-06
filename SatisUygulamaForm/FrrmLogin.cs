namespace SatisUygulamaForm
{
    public partial class LoginPanel : Form
    {

        public LoginPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string kullanıciadi = textBox1.Text;
            string sifre = textBox2.Text;

            if (kullanıciadi == "admin" && sifre == "admin1")
            {

                this.Hide();
                FrmİslemSecme frm = new FrmİslemSecme();
                frm.Show();
            }
            else
            {
                label5.Show();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}