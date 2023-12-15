using DevExpress.XtraRichEdit.API.Native;
using HizliSatis.Application.Abstract;
using HizliSatis.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
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
            var loginForm = System.Windows.Forms.Application.OpenForms[nameof(frmLogin)];
            if (loginForm != null && loginForm is frmLogin)
            {
                ((frmLogin)loginForm).Show();
            }
        }



        private void frmIslemSecme_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            var urunEkle = Program.ServiceProvider.GetRequiredService<frmUrunEkle>();
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
            //new frmLogin().Show();
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnKullaniciDegistir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //frmLogin frmLogin = new frmLogin();
            //frmLogin.Show();
            var loginForm = System.Windows.Forms.Application.OpenForms[nameof(frmLogin)];
            if (loginForm != null && loginForm is frmLogin)
            {
                ((frmLogin)loginForm).Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Satisİslemi = Program.ServiceProvider.GetRequiredService<frmSatis>();
            Satisİslemi.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            new frmMusteriler().ShowDialog();
        }

        private void btnStokTakibi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var stokTakibi = Program.ServiceProvider.GetRequiredService<frmStokTakibi>();
            stokTakibi.Show();
        }

        private void btnStokListesi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmStokListesi = Program.ServiceProvider.GetRequiredService<frmStokListesi>();
            frmStokListesi.Show();
        }
    }
}
