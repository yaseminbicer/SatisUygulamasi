using HizliSatis.Domain.Entities;

namespace HizliSatis.UI.Forms
{
    public partial class frmKartEkle : Form
    {
        public frmKartEkle()
        {
            InitializeComponent();
        }
        private void YeniKart()
        {
            using var dbContextKart = new AppDbContext();
            var YeniKart = new Stok
            {
                Ad = UrunAdi.Text,
                Birim = txtBirimi.Text,
               
                KdvOrani = Convert.ToInt32(txtKdvOrani.Text),
                AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text),
                SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text),
               

            };
            dbContextKart.Add(YeniKart);
            dbContextKart.SaveChanges();
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
            using var dbContextKart = new AppDbContext();
            var GuncellenecekKart = dbContextKart.Stok.Find(id);
            GuncellenecekKart.Ad = UrunAdi.Text;
            GuncellenecekKart.Birim = txtBirimi.Text;
            GuncellenecekKart.KdvOrani = Convert.ToInt32(txtKdvOrani.Text);
            GuncellenecekKart.AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text);
            GuncellenecekKart.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
            dbContextKart.Update(GuncellenecekKart);
            dbContextKart.SaveChanges();
        }
    }
}
