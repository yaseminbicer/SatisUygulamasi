using DevExpress.XtraSpreadsheet.Model;
using HizliSatis.Application.Abstract;
using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Concretes;

namespace HizliSatis.UI.Forms
{
    public partial class frmStokListesiDetay : Form
    {
        private int Id;
        private readonly IRepository<Stok> _repository;

        public frmStokListesiDetay(IRepository<Stok> repository,int id = 0)
        {
            _repository = repository;
            Id = id;
            if (id > 0)
            {
                Stok stok = _repository.Get(id);

                txtUrunAciklama.Text = stok.Aciklama;
                txtSatisFiyati.Text = Convert.ToString(stok.SatisFiyati);
                txtUrunAdi.Text = stok.Ad;
                txtAlisFiyati.Text = Convert.ToString(stok.AlisFiyati);
                txtBarkod.Text = stok.Barkod;
                txtBirimi.Text = stok.Birim;
                txtKdvOrani.Text = Convert.ToString(stok.KdvOrani);
                txtUrunGrubu.Text = stok.UrunGrubu;
            }
        }


        public frmStokListesiDetay()
        {
            InitializeComponent();
        }

        private void frmStokListesiDetay_Load(object sender, EventArgs e)
        {

        }

        public void Kaydet()
        {
            var stok = Id == 0 ? new Stok() : _repository.Get(Id);

            stok.Aciklama = txtUrunAciklama.Text;
            stok.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
            stok.Ad = txtUrunAdi.Text;
            stok.AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text);
            stok.Barkod = txtBarkod.Text;
            stok.Birim = txtBirimi.Text;
            stok.KdvOrani = Convert.ToInt32(txtKdvOrani.Text);
            stok.UrunGrubu = txtUrunGrubu.Text;
            if (Id == 0)
                _repository.Create(stok);
            else
                _repository.Update(stok);
            Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
    }



}
