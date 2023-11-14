using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Concretes;

namespace HizliSatis.UI.Forms
{
    public partial class frmStokListesiDetay : Form
    {
        private readonly IProductService _productService = new ProductService();
        private int Id;
        public frmStokListesiDetay(int id)
        {
            InitializeComponent();
            Id = id;

            if (id > 0)
            {
                var urun = _productService.GetStokById(Id);

                if (urun != null)
                {
                    txtUrunAciklama.Text = urun.Aciklama;
                    txtSatisFiyati.Text = Convert.ToString(urun.SatisFiyati);
                    txtUrunAdi.Text = urun.Ad;
                    txtAlisFiyati.Text = Convert.ToString(urun.AlisFiyati);
                    txtBarkod.Text = urun.Barkod;
                    txtBirimi.Text = urun.Birim;
                    txtKdvOrani.Text = Convert.ToString(urun.KdvOrani);
                    txtUrunGrubu.Text = urun.UrunGrubu;
            
                }
            }

        }
        private void frmStokListesiDetay_Load(object sender, EventArgs e)
        {

        }

        public void Kaydet()
        {
            var stok = Id == 0 ? new Stok() : _productService.GetStokById(Id);

            stok.Aciklama = txtUrunAciklama.Text;
            stok.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
            stok.Ad = txtUrunAdi.Text;
            stok.AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text);
            stok.Barkod = txtBarkod.Text;
            stok.Birim = txtBirimi.Text;
            stok.KdvOrani = Convert.ToInt32(txtKdvOrani.Text);
            stok.UrunGrubu = txtUrunGrubu.Text;
            if (Id == 0)
                _productService.AddProduct(stok);
            else
                _productService.UpdateProduct(Id);
                _productService.SaveChanges();

            Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
    }



}
