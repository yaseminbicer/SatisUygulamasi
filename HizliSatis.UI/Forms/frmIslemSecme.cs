
using HizliSatis.Application.Abstractions;
using DevExpress.XtraEditors;
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
    public partial class frmIslemSecme : DevExpress.XtraEditors.XtraForm
    {

        private readonly IProductService _productService;

        public frmIslemSecme(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
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
            //var urunEkle = Program.ServiceProvider.GetRequiredService<frmStokEkle>();
           // urunEkle.Show();
        }

        private void frmIslemSecme_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            //var frmKullanicilar = Program.ServiceProvider.GetRequiredService<frmKullanicilar>();
            //frmKullanicilar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var _frmLogin = Program.ServiceProvider.GetRequiredService<frmLogin>();
            _frmLogin.Show();
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
            var SatisIslemi = Program.ServiceProvider.GetRequiredService<frmSatisnew>();
            SatisIslemi.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            var frmMusteriler = Program.ServiceProvider.GetRequiredService<frmMusteriler>();
            frmMusteriler.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmHome = Program.ServiceProvider.GetRequiredService<frmAnaMenu>();
            frmHome.Show();
        }
    }
}
