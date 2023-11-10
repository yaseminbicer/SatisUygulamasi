using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Concretes;

namespace HizliSatis.UI.Forms
{

    public partial class frmStokListesi : Form
    {
        private readonly IProductService _productService = new ProductService();
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
                var form = System.Windows.Forms.Application.OpenForms[nameof(frmIslemSecme)];
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
