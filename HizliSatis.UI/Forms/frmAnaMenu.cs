using DevExpress.DataAccess.Native;
using DevExpress.XtraBars.FluentDesignSystem;
using HizliSatis.UI.Extra;
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
        public frmAnaMenu()
        {
            InitializeComponent();
            sidePanel.Height = btnStok.Height;

        }


        private void frmAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnStok_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = btnStok.Height;
            sidePanel.Top = btnStok.Top;
            ucStok ucStok = new ucStok();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucStok);

        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnKategoriler.Height;
            sidePanel.Top = btnKategoriler.Top;
        }

        private void btnKasaTanimlama_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnKasaTanimlama.Height;
            sidePanel.Top = btnKasaTanimlama.Top;
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnKullanicilar.Height;
            sidePanel.Top = btnKullanicilar.Top;
            ucKullanicilar ucKullanicilar = new ucKullanicilar();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucKullanicilar);
        }

        private void btnOdemeTanimlama_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnOdemeTanimlama.Height;
            sidePanel.Top = btnOdemeTanimlama.Top;
        }

        private void btnFisveFaturalar_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnFisveFaturalar.Height;
            sidePanel.Top = btnFisveFaturalar.Top;
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnRaporlar.Height;
            sidePanel.Top = btnRaporlar.Top;
        }
    }
}

