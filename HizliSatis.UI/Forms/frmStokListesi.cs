﻿using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Concretes;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using DevExpress.CodeParser;
using DevExpress.Data.Helpers;
namespace HizliSatis.UI.Forms
{

    public partial class frmStokListesi : Form
    {
        private readonly IProductService _productService;
        
        public frmStokListesi(IProductService productService)
        {
            InitializeComponent();
            btnDuzenle.Click += btnDuzenle_Click;
            Activated += (s, e) =>
            {
                UrunListele();
            };

            FormClosed += (s, e) =>
            {
                var form = System.Windows.Forms.Application.OpenForms[nameof(frmIslemSecme)];
                form.Show();
            };

            btnIptal.Click += (s, e) => Close();
            _productService = productService;
           

        }
        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            UrunListele();
        }
      

        private void btnDuzenle_Click(object? sender, EventArgs e)
        {
            Duzenle();
        }

        private void UrunListele()
        {
            gridStokListesi.DataSource = _productService.GetProducts();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                Duzenle();
            }

        }

        private void Duzenle()
        {            
            var stok = ((Stok)gridView1.GetFocusedRow());
            var stokListesiDetay =  new frmStokListesiDetay(stok.Id,Program.ServiceProvider.GetRequiredService<IProductService>());            
            stokListesiDetay.ShowDialog();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var stokListesiDetay = new frmStokListesiDetay(0, Program.ServiceProvider.GetRequiredService<IProductService>());
          
           // _productService.AddProduct();
     
            stokListesiDetay.ShowDialog();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekStok = (Stok)gridView1.GetFocusedRow();
            _productService.RemoveProduct(silinecekStok);
            gridView1.DeleteRow(gridView1.FocusedRowHandle);

            UrunListele();
        }
    }


}
