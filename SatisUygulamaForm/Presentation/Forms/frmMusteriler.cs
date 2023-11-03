using Microsoft.EntityFrameworkCore;
using SatisUygulamaForm.Domain.Entity;
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
    public partial class frmMusteriler : DevExpress.XtraEditors.XtraForm
    {
        AppDbContext dbContext = new AppDbContext();
        BindingList<Musteri> Musteriler { get; set; }
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            var data = dbContext.Musteri.ToList();
            Musteriler = new BindingList<Musteri>(data);
            gridMusteri.DataSource = Musteriler;

        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (var musteri in Musteriler.Where(s => s.Id == 0))
            {
                dbContext.Add(musteri);
            }
            int result = dbContext.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var musteri = (Musteri)viewMusteri.GetFocusedRow();
            dbContext.Remove(musteri);
            viewMusteri.DeleteRow(viewMusteri.FocusedRowHandle);
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
            new frmIslemSecme().Show();

        }
    }
}
