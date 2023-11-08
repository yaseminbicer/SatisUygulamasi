using DevExpress.CodeParser;
using SatisUygulamaForm.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisUygulamaForm.Presentation.Forms
{
    public partial class frmStokListesiDetay : Form
    {
        private int Id;
        private AppDbContext db = new AppDbContext();
        public frmStokListesiDetay(int id = 0)
        {
            InitializeComponent();
            Id = id;
            if (id > 0)
            {
                var stok = db.Stok.Find(id);
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



        private void frmStokListesiDetay_Load(object sender, EventArgs e)
        {

        }

        public void Kaydet()
        {
            var stok = Id == 0 ? new Stok() : db.Stok.Find(Id);

            stok.Aciklama = txtUrunAciklama.Text;
            stok.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
            stok.Ad = txtUrunAdi.Text;
            stok.AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text);
            stok.Barkod = txtBarkod.Text;
            stok.Birim = txtBirimi.Text;
            stok.KdvOrani = Convert.ToInt32(txtKdvOrani.Text);
            stok.UrunGrubu = txtUrunGrubu.Text;
            if (Id == 0)
                db.Add(stok);
            else
                db.Update(stok);
            db.SaveChanges();

            Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
    }



}
