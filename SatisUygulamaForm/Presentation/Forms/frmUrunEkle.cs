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
using DevExpress.XtraEditors;

namespace SatisUygulamaForm
{
    public partial class frmUrunEkle : XtraForm
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            UrunListele();
        }


        public void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
            UrunListele();
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            Kapat();
        }


        private void btnKaydetCik_Click(object sender, EventArgs e)
        {
            Kaydet();
            Kapat();
        }

        private void BilgileriTemizle()
        {
            txtAlisFiyati.Text = "";
            txtBarkod.Text = "";
            txtKdvOrani.Text = "";
            txtSatisFiyati.Text = "";
            txtUrunAciklama.Text = "";
            txtUrunAdi.Text = "";
            txtId.Text = "0";
            txtBirimi.Text = "";
            txtUrunGrubu.Text = "";
        }

        private void Kapat()
        {
            Close();
            frmIslemSecme IslemSecme = new frmIslemSecme();
            IslemSecme.Show();
        }

        private void Guncelle(int id)
        {
            using var dbContext = new AppDbContext();
            var guncellenecekStok = dbContext.Stok.Find(id);
            guncellenecekStok.Aciklama = txtUrunAciklama.Text;
            guncellenecekStok.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.EditValue);
            guncellenecekStok.Ad = txtUrunAdi.Text;
            guncellenecekStok.AlisFiyati = Convert.ToDecimal(txtAlisFiyati.EditValue);
            guncellenecekStok.Barkod = txtBarkod.Text;
            guncellenecekStok.Birim = txtBirimi.Text;
            guncellenecekStok.KdvOrani = Convert.ToInt32(txtKdvOrani.Text);
            guncellenecekStok.UrunGrubu = txtUrunGrubu.Text;
            dbContext.Update(guncellenecekStok);
            dbContext.SaveChanges();
        }

        private void Kaydet()
        {
            if (txtId.Text == "" || txtId.Text == "0")
                Yeni();
            else Guncelle(Convert.ToInt32(txtId.Text));
            BilgileriTemizle();
        }

        private void Yeni()
        {
            using var dbContext = new AppDbContext();
            var yeniStok = new Stok
            {
                Aciklama = txtUrunAciklama.Text,
                SatisFiyati = Convert.ToDecimal(txtSatisFiyati.EditValue),
                Ad = txtUrunAdi.Text,
                AlisFiyati = Convert.ToDecimal(txtAlisFiyati.EditValue),
                Barkod = txtBarkod.Text,
                Birim = txtBirimi.Text,
                KdvOrani = Convert.ToInt32(txtKdvOrani.Text),
                UrunGrubu = txtUrunGrubu.Text
            };

            dbContext.Add(yeniStok);
            dbContext.SaveChanges();
        }

        private void UrunListele()
        {
            using var dbContext = new AppDbContext();
            gridUrunEkle.DataSource = dbContext.Stok.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using var dbContext = new AppDbContext();
            var silinecekUrun = (Stok)gridView1.GetFocusedRow();
            dbContext.Remove(silinecekUrun);
            dbContext.SaveChanges();
            UrunListele();
        }

        private void Yazdir()
        {
            var guncellenecekStok = (Stok)gridView1.GetFocusedRow();
            txtUrunAdi.Text = guncellenecekStok.Ad;
            txtAlisFiyati.Text = Convert.ToString(guncellenecekStok.AlisFiyati);
            txtBarkod.Text = guncellenecekStok.Barkod;
            txtKdvOrani.Text = Convert.ToString(guncellenecekStok.KdvOrani);
            txtSatisFiyati.Text = Convert.ToString(guncellenecekStok.SatisFiyati);
            txtUrunAciklama.Text = guncellenecekStok.Aciklama;
            txtBirimi.Text = guncellenecekStok.Birim;
            txtUrunGrubu.Text = guncellenecekStok.UrunGrubu;

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                Yazdir();
            }

        }


    }
}
