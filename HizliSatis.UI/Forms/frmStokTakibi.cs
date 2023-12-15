using HizliSatis.Application.Abstract;
using HizliSatis.Application.Concretes;
using HizliSatis.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace HizliSatis.UI.Forms
{
    public partial class frmStokTakibi : DevExpress.XtraEditors.XtraForm
    {
        private readonly IRepository<Stok> _repository;
        public frmStokTakibi(IRepository<Stok> repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void btnKartEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            var KartEkle = Program.ServiceProvider.GetRequiredService<frmKartEkle>();
            KartEkle.Show();
        }

        /*public void gridStokTakibi_RowClick(object sender, EventArgs e, int id)
        {
            
            if (e.Clicks == 2)
            {
                using var dbContextKart = new AppDbContext();
                var GuncellenecekKart = dbContextKart.Stok.Find(id);
            }
            this.Hide();
            frmKartEkle kartEkle = new frmKartEkle();
            kartEkle.Show();
            var guncellenecekStok = (Stok)gridView1.GetFocusedRow();
        }*/
    }
}