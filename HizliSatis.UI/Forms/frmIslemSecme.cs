
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HizliSatis.UI.Forms
{
    public partial class frmIslemSecme : Form
    {
        public frmIslemSecme()
        {
            InitializeComponent();
        }


        private void btnKullaniciDegistir_Click(object sender, EventArgs e)
        {
            this.Hide();
          
            var loginform = System.Windows.Forms.Application.OpenForms[0];
            if (loginform != null && loginform is frmLogin)
            {
                loginform.Show();
            }
        }



        private void frmIslemSecme_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUrunEkle urunEkle = new frmUrunEkle();
            urunEkle.Show();
        }

        private void frmIslemSecme_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            new frmKullanicilar().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnKullaniciDegistir_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            var loginform = System.Windows.Forms.Application.OpenForms[0];
            if (loginform != null && loginform is frmLogin)
            {
                loginform.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSatis Satisİslemi = new frmSatis();
            Satisİslemi.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            new frmMusteriler().ShowDialog();
        }

        private void btnStokTakibi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStokTakibi stokTakibi = new frmStokTakibi();
            stokTakibi.Show();
        }

        private void btnStokListesi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStokListesi frmStokListesi = new frmStokListesi();
            frmStokListesi.Show();
        }
    }
}
