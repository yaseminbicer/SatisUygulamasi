using DevExpress.XtraEditors;
using HizliSatis.Application.Abstract;
using HizliSatis.Application.Concretes;
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
    public partial class frmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        private readonly IRepository<Kullanici> _repository;

        public frmKullanicilar(IRepository<Kullanici> repository)
        {
            _repository = repository;
        }
        public frmKullanicilar()
        {
            InitializeComponent();
        }

        BindingList<Kullanici> Kullanicilar { get; set; }

        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            var data = _repository.GetAllList();
            Kullanicilar = new BindingList<Kullanici>(data);
            gridKullanici.DataSource = Kullanicilar;
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (var kullanici in Kullanicilar.Where(s => s.Id == 0))
            {
                _repository.Create(kullanici);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var kullanici = (Kullanici)viewKullanici.GetFocusedRow();
            _repository.Delete(kullanici);
            viewKullanici.DeleteRow(viewKullanici.FocusedRowHandle);
        }

        private void gridKullanici_Click(object sender, EventArgs e)
        {

        }
    }
}