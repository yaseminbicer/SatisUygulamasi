using DevExpress.CodeParser;
using Microsoft.EntityFrameworkCore;
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
using System.Windows.Input;

namespace SatisUygulamaForm.Presentation.Forms
{

    public partial class frmStokListesi : Form
    {
        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            UrunListele();
        }
        public frmStokListesi()
        {
            InitializeComponent();
            btnDuzenle.Click += btnDuzenle_Click;
            Activated += (s, e) =>
            {
                UrunListele();
            };

            FormClosed += (s, e) =>
            {
                var form = Application.OpenForms[nameof(frmIslemSecme)];
                form.Show();
            };

            btnIptal.Click += (s, e) => Close();
        }

        private void btnDuzenle_Click(object? sender, EventArgs e)
        {
            Duzenle();
        }

        private void UrunListele()
        {
            using var dbcontext = new AppDbContext();
            gridStokListesi.DataSource = dbcontext.Stok.ToList();


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
            frmStokListesiDetay stokListesiDetay = new frmStokListesiDetay(stok.Id);
            stokListesiDetay.ShowDialog();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmStokListesiDetay stokListesiDetay = new frmStokListesiDetay();
            stokListesiDetay.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var stok = ((Stok)gridView1.GetFocusedRow());
            using var dbcontext = new AppDbContext();
            var silinecekStok = dbcontext.Stok.Find(stok.Id);
            dbcontext.Remove(silinecekStok);
            dbcontext.SaveChanges();
            UrunListele();
        }
    }


}
