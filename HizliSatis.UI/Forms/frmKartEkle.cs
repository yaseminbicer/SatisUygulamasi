using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Concretes;

namespace HizliSatis.UI.Forms
{
    public partial class frmKartEkle : Form
    {
        private readonly IProductService _productService = new ProductService();
        public frmKartEkle()
        {
            InitializeComponent();
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
            _productService.AddProduct(YeniKart);
            _productService.SaveChanges();
        }


        private void Kaydet()
        {
            if (txtId.Text == "" || txtId.Text == "0")
                YeniKart();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
            frmKartEkle kartEkle = new frmKartEkle();
            kartEkle.ShowDialog();
        }

        public void Guncelle(int id)
        {
            var guncellenecekStok = _productService.GetStokById(id);
            if (guncellenecekStok != null)
            {
                guncellenecekStok.Ad = UrunAdi.Text;
                guncellenecekStok.Birim = txtBirimi.Text;
                guncellenecekStok.KdvOrani = Convert.ToInt32(txtKdvOrani.Text);
                guncellenecekStok.AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text);
                guncellenecekStok.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
                _productService.UpdateProduct(id);
           
            }
        }

    }
}
