using DevExpress.XtraEditors;
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

namespace HizliSatis.Form.Forms.Presentation.Forms
{
    public partial class frmStokTakibi : DevExpress.XtraEditors.XtraForm
    {
        public frmStokTakibi()
        {
            InitializeComponent();
        }

        private void btnKartEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKartEkle KartEkle = new frmKartEkle();
            KartEkle.Show();
        }

        /*public void gridStokTakibi_RowClick(object sender, EventArgs e, int id)
        {
            
            if (e.Clicks == 2)
            {
                using var dbContextKart = new AppDbContext();
                var GuncellenecekKart = dbContextKart.Stok.Find(id);
            }
            this.Hide();
            frmKartEkle kartEkle = new frmKartEkle();
            kartEkle.Show();
            var guncellenecekStok = (Stok)gridView1.GetFocusedRow();
        }*/
    }
}