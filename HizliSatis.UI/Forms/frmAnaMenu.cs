using DevExpress.DataAccess.Native;
using DevExpress.XtraBars.FluentDesignSystem;
using HizliSatis.Application.Abstractions;
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
    public partial class frmAnaMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly IProductService _productService;

        public frmAnaMenu(IProductService ProductService)
        {
            InitializeComponent();
            _productService = ProductService;
            sidePanel.Height = btnStok.Height;
        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnStok_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = btnStok.Height;
            sidePanel.Top = btnStok.Top;
            var ucStok = Program.ServiceProvider.GetService<ucStok>();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucStok);

        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnKategoriler.Height;
            sidePanel.Top = btnKategoriler.Top;
            var ucKategoriTanimlama = Program.ServiceProvider.GetService<ucKategoriTanimlama>();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucKategoriTanimlama);
        }

        private void btnKasaTanimlama_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnKasaTanimlama.Height;
            sidePanel.Top = btnKasaTanimlama.Top;
            panelMain.Controls.Clear();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnKullanicilar.Height;
            sidePanel.Top = btnKullanicilar.Top;
            var ucKullanicilar = Program.ServiceProvider.GetService<ucKullanicilar>();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucKullanicilar);
        }

        private void btnOdemeTanimlama_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnOdemeTanimlama.Height;
            sidePanel.Top = btnOdemeTanimlama.Top;
            panelMain.Controls.Clear();
        }

        private void btnFisveFaturalar_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnFisveFaturalar.Height;
            sidePanel.Top = btnFisveFaturalar.Top;
            panelMain.Controls.Clear();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnRaporlar.Height;
            sidePanel.Top = btnRaporlar.Top;
            panelMain.Controls.Clear();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            var _frmSatisnew = System.Windows.Forms.Application.OpenForms[1];
            _frmSatisnew.Show();
            
        }
    }
}

