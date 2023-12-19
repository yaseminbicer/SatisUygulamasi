using HizliSatis.Application.Abstract;
using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace HizliSatis.UI.Forms
{
    public partial class frmKartEkle : Form
    {
        private readonly IRepository<Stok> _repository;

        public frmKartEkle(IRepository<Stok> repository)
        {
            InitializeComponent();
            _repository = repository;
        }
        private void YeniKart()
        {
            var YeniKart = new Stok
            {
                Ad = UrunAdi.Text,
                Birim = txtBirimi.Text,

                KdvOrani = Convert.ToInt32(txtKdvOrani.Text),
                AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text),
                SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text),
            };
            _repository.Create(YeniKart);
        }


        private void Kaydet()
        {
            if (txtId.Text == "" || txtId.Text == "0")
                YeniKart();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
            var kartEkle = Program.ServiceProvider.GetRequiredService<frmKartEkle>();
            kartEkle.ShowDialog();
        }

        public void Guncelle(int id)
        {
            var GuncellenecekKart = _repository.Get(id);
            GuncellenecekKart.Ad = UrunAdi.Text;
            GuncellenecekKart.Birim = txtBirimi.Text;
            GuncellenecekKart.KdvOrani = Convert.ToInt32(txtKdvOrani.Text);
            GuncellenecekKart.AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text);
            GuncellenecekKart.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
            _repository.Update(GuncellenecekKart);
        }
    }
}
