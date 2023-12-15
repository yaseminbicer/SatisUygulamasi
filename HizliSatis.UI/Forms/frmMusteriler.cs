using HizliSatis.Application.Abstract;
using HizliSatis.Application.Concretes;
using HizliSatis.Domain.Entities;
using System.ComponentModel;
using System.Data;

namespace HizliSatis.UI.Forms
{
    public partial class frmMusteriler : DevExpress.XtraEditors.XtraForm
    {
        private readonly IRepository<Musteri> _repository;

        public frmMusteriler(IRepository<Musteri> repository)
        { 
            _repository = repository;
        }

        public frmMusteriler()
        {
            InitializeComponent();
        }


        BindingList<Musteri> Musteriler { get; set; }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            var data = _repository.GetAllList();
            Musteriler = new BindingList<Musteri>(data);
            gridMusteri.DataSource = Musteriler;

        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (var musteri in Musteriler.Where(s => s.Id == 0))
            {
                _repository.Create(musteri);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var musteri = (Musteri)viewMusteri.GetFocusedRow();
            _repository.Delete(musteri);
            viewMusteri.DeleteRow(viewMusteri.FocusedRowHandle);
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
            new frmIslemSecme().Show();
        }

    }
}
