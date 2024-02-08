using DevExpress.XtraEditors;
using HizliSatis.Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using HizliSatis.Domain.Entities;
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
    public partial class ucSettings : DevExpress.XtraEditors.XtraUserControl
    {
        Form _frmSatisnew = System.Windows.Forms.Application.OpenForms[1];

        public ucSettings()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }

        }

        private void btnKasaYonetimi_Click(object sender, EventArgs e)
        {
            //var _frmSatisnew = System.Windows.Forms.Application.OpenForms[1];
            _frmSatisnew.Hide();
            var _frmAnaMenu = Program.ServiceProvider.GetRequiredService<frmAnaMenu>();
            _frmAnaMenu.Show();
        }

        private void btnKullaniciDegistir_Click(object sender, EventArgs e)
        {
            _frmSatisnew.Hide();
            var _frmLogin = Program.ServiceProvider.GetRequiredService<frmLogin>();
            _frmLogin.Show();
        }

        private void btnStokListesi_Click(object sender, EventArgs e)
        {
            _frmSatisnew.Hide();
            var _frmStokListesi = Program.ServiceProvider.GetRequiredService<frmStokListesi>();
            _frmStokListesi.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            _frmSatisnew.Hide();
            var _frmmusteriler = Program.ServiceProvider.GetRequiredService<frmMusteriler>();
            _frmmusteriler.Show();
        }
    }
}
