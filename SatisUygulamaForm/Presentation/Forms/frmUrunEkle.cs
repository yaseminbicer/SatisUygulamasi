using DevExpress.Mvvm.Native;
using SatisUygulamaForm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisUygulamaForm
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void KdvOrani_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunGrubuEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnBarkodOlustur_Click(object sender, EventArgs e)
        {
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "" && txtUrunAdi.Text != "" && cmbxUrunGrubu.Text != "" && txtAlisFiyati.Text != "" && txtSatisFiyati.Text != "" && txtKdvOrani.Text != "" && txtMiktar.Text != "")
            {
                Urun Urun = new Urun();
                Urun.Barkod = txtBarkod.Text;
                Urun.ÜrünAdi = txtUrunAdi.Text;
                Urun.Aciklama = txtUrunAciklama.Text;
                Urun.UrunGrup = cmbxUrunGrubu.Text;
                Urun.AlisFiyati = Convert.ToDouble(txtAlisFiyati.Text);
                Urun.SatisFiyati = Convert.ToDouble(txtSatisFiyati.Text);
                Urun.KdvOrani = Convert.ToInt32(txtKdvOrani.Text);



            }
        }

        private void txtBarkod_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
