using DevExpress.XtraEditors;

namespace SatisUygulamaForm
{
    public partial class frmLogin : XtraForm
    {

        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string kullanıciadi = textBox1.Text;
            string sifre = textBox2.Text;

            if (kullanıciadi == "admin" && sifre == "admin1")
            {

                this.Hide();
                frmIslemSecme frm = new frmIslemSecme();
                frm.Show();
            }
            else
            {
                label5.Show();
            }

        }
    }
}