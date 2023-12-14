﻿using DevExpress.DirectX.Common.Direct2D;
using DevExpress.XtraEditors;
using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Concretes;
using Microsoft.Extensions.Logging;

namespace HizliSatis.UI.Forms
{
    public partial class frmUrunEkle : XtraForm
    {

        /*private readonly IProductService<frmUrunEkle> _productService;
        public frmUrunEkle(IProductService<frmUrunEkle> productService)
        {
            _productService = productService;
            InitializeComponent();
        }*/

        private readonly IProductService _productService;
        public frmUrunEkle(IProductService ProductService)
         {
             _productService = ProductService;

             InitializeComponent();
         }

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
            var guncellenecekStok = _productService.GetStokById(id);

            if (guncellenecekStok != null)
            {
                guncellenecekStok.Aciklama = txtUrunAciklama.Text;
                guncellenecekStok.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.EditValue);
                guncellenecekStok.Ad = txtUrunAdi.Text;
                guncellenecekStok.AlisFiyati = Convert.ToDecimal(txtAlisFiyati.EditValue);
                guncellenecekStok.Barkod = txtBarkod.Text;
                guncellenecekStok.Birim = txtBirimi.Text;
                guncellenecekStok.KdvOrani = Convert.ToInt32(txtKdvOrani.Text);
                guncellenecekStok.UrunGrubu = txtUrunGrubu.Text;

                _productService.UpdateProduct(id);

            }
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
            _productService.AddProduct(yeniStok);
            _productService.SaveChanges();
        }

        private void UrunListele()
        {
            gridUrunEkle.DataSource = _productService.GetProducts();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekUrun = (Stok)gridView1.GetFocusedRow();
            _productService.RemoveProduct(silinecekUrun);
            _productService.SaveChanges();
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