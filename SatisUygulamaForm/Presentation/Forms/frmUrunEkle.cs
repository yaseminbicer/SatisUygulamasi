using DevExpress.Mvvm.Native;
using SatisUygulamaForm.Domain.Entity;
using SatisUygulamaForm.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Infrastructure;
using DevExpress.Utils.Animation;

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

        public readonly AppDbContext _dbContext;

        public frmUrunEkle(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void btnKaydet_Click(object sender, EventArgs e)
        {
            AppDbContext db = new();
            Urun yeniUrun = new()
            {
                ÜrünAdi = txtUrunAdi.Text,
                Barkod = txtBarkod.Text,
                UrunAciklama = txtUrunAciklama.Text,
                UrunGrubu = cmbxUrunGrubu.Text,
                AlisFiyati = System.Convert.ToDouble(txtAlisFiyati.Text),
                SatisFiyati = System.Convert.ToDouble(txtSatisFiyati.Text),
                KdvOrani = System.Convert.ToInt32(txtKdvOrani.Text),
                Miktar = System.Convert.ToDecimal(txtMiktar.Text),
                Birimi = cmbxBrimi.Text,
                Tarih = DateTime.Now,

                
             };
            
          
           


        }

        private void frmUrunEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
