using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
using HizliSatis.Application.Abstractions;
using HizliSatis.Persistence.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace HizliSatis.UI.Forms
{
    public partial class frmSatisnew : DevExpress.XtraEditors.XtraForm
    {
        private readonly IProductService _productService;


        public frmSatisnew(IProductService ProductService)
        {
            _productService = ProductService;
            InitializeComponent();
            sidePanel.Height = btnIkram.Height;

        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnAyarlar.Height;
            sidePanel.Top = btnAyarlar.Top;
            var ucSettings = Program.ServiceProvider.GetService<ucSettings>();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucSettings);
        }

        private void btnIkram_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnIkram.Height;
            sidePanel.Top = btnIkram.Top;
            panelMain.Controls.Clear();
        }

        private void btnIndirim_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnIndirim.Height;
            sidePanel.Top = btnIndirim.Top;
            panelMain.Controls.Clear();
        }

        private void btnFis_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnFis.Height;
            sidePanel.Top = btnFis.Top;
            panelMain.Controls.Clear();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnUrunSil.Height;
            sidePanel.Top = btnUrunSil.Top;
            panelMain.Controls.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnTemizle.Height;
            sidePanel.Top = btnTemizle.Top;
            panelMain.Controls.Clear();
        }

        private void btnTuslar_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnTuslar.Height;
            sidePanel.Top = btnTuslar.Top;
            panelMain.Controls.Clear();
        }
    }
}
