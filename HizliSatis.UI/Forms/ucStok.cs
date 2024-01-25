using DevExpress.XtraEditors;
using HizliSatis.Application.Abstractions;
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
    public partial class ucStok : DevExpress.XtraEditors.XtraUserControl
    {
        public ucStok()
        {
            InitializeComponent();
        }
        private readonly IProductService _productService;
        public ucStok(IProductService ProductService)
        {
            _productService = ProductService;

        }
        private void ucStok_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void Kaydet()
        {
            if (txtId.Text == "" || txtId.Text == "0")
                Yeni();
            else Guncelle(Convert.ToInt32(txtId.Text));
            BilgileriTemizle();
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
            //Close();
            //  var IslemSecme = Program.ServiceProvider.GetRequiredService<frmIslemSecme>();

            //IslemSecme.Show();
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
            var silinecekUrun = (Stok)viewUrunEkle.GetFocusedRow();
            _productService.RemoveProduct(silinecekUrun);
            _productService.SaveChanges();
            UrunListele();
        }

        private void Yazdir()
        {
            var guncellenecekStok = (Stok)viewUrunEkle.GetFocusedRow();
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

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            var ImageFile = new OpenFileDialog();
            ImageFile.FileName = "";
            ImageFile.Filter = "Resim Dosyası|*.png";
            if(ImageFile.ShowDialog() == DialogResult.OK) pImage.Image=Image.FromFile(ImageFile.FileName);
        }
    }
}
