using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SatisUygulamaForm
{
    public partial class frmIslemSecme : Form
    {
        public frmIslemSecme()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSatis Satisİslemi = new frmSatis();
            Satisİslemi.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKullaniciDegistir_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmLogin frmLogin = new frmLogin();
            //frmLogin.Show();
            var loginForm = Application.OpenForms[0];
            if (loginForm != null && loginForm is frmLogin)
            {
                ((frmLogin)loginForm).Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUrunEkle urunEkle = new frmUrunEkle();
            urunEkle.Show();    
        }
    }
}
