using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisUygulamaForm
{
    public partial class frmSatis : Form
    {
        Fis fis = new Fis();
        public frmSatis()
        {
            InitializeComponent();
            fis.Tarih = DateTime.Now;
            fis.FisNo = DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Barkod_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void tBarkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void tMiktar_TextChanged(object sender, EventArgs e)
        {


        }

        private void Ara_Click(object sender, EventArgs e)

        {

            string girilenBarkod = tBarkod.Text;
            Urun arananUrun = UrunList.urunListesi.Find(urun => urun.Barkod == girilenBarkod);

            if (arananUrun != null)
            {
                fis.FisSatirlari.Add(new FisSatir
                {
                    Barkod = arananUrun.Barkod,
                    BirimFiyat = arananUrun.BrFiyat,
                    Miktar = Convert.ToDecimal(tMiktar.Text),
                    StokAdi = arananUrun.ÜrünAdı,
                    StokKodu = arananUrun.Barkod,
                    Birim = arananUrun.Birimi
                });
                gridControl1.DataSource = fis.FisSatirlari;
                //GridSatisListesi.Rows.Clear(); // DataGridView'i temizle
                //GridSatisListesi.Rows.Add(arananUrun.Barkod, arananUrun.ÜrünAdı, arananUrun.BrFiyat, arananUrun.Miktar, arananUrun.Birimi, arananUrun.GenelToplam);
            }
            else
            {
                MessageBox.Show("Ürün bulunamadı.");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

