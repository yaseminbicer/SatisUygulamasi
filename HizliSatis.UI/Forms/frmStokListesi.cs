using HizliSatis.Application.Abstract;
using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace HizliSatis.UI.Forms
{

    public partial class frmStokListesi : Form
    {
        private readonly IRepository<Stok> _repository;

        public frmStokListesi(IRepository<Stok> repository)
        {
            _repository = repository;
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

            gridStokListesi.DataSource = _repository.GetAllList();
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
            var stokListesiDetay = Program.ServiceProvider.GetRequiredService<frmStokListesiDetay>();
            stokListesiDetay.ShowDialog();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var stokListesiDetay = Program.ServiceProvider.GetRequiredService<frmStokListesiDetay>();
            stokListesiDetay.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var stok = ((Stok)gridView1.GetFocusedRow());
            var silinecekStok =  _repository.Get(stok.Id);
             _repository.Delete(silinecekStok);
            UrunListele();
        }
    }


}
