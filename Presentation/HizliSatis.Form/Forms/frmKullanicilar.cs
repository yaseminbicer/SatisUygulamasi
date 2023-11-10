using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SatisUygulamaForm.Persistence;
using SatisUygulamaForm.Domain.Entity;

namespace HizliSatis.Form.Forms.Presentation.Forms
{
    public partial class frmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        AppDbContext dbContext = new AppDbContext();
        BindingList<Kullanici> Kullanicilar { get; set; }
        public frmKullanicilar()
        {
            InitializeComponent();
            //Kullanicilar.AddingNew += (s, e) =>
            //{
            //    dbContext.Add((Kullanici)e.NewObject);
            //};
        }

        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            var data = dbContext.Kullanici.ToList();
            Kullanicilar = new BindingList<Kullanici>(data);
            gridKullanici.DataSource = Kullanicilar;
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (var kullanici in Kullanicilar.Where(s => s.Id == 0))
            {
                dbContext.Add(kullanici);
            }
            int result = dbContext.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var kullanici = (Kullanici)viewKullanici.GetFocusedRow();
            dbContext.Remove(kullanici);
            viewKullanici.DeleteRow(viewKullanici.FocusedRowHandle);
        }

        private void gridKullanici_Click(object sender, EventArgs e)
        {

        }
    }
}