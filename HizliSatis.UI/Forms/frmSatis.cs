using DevExpress.XtraEditors;
using HizliSatis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace HizliSatis.UI.Forms
{
    public partial class frmSatis : Form
    {
        AppDbContext dbContext = new AppDbContext();
        BindingList<Stok> Stok { get; set; }
        Fis fis = new Fis();
        public frmSatis()
        {
            InitializeComponent();
            fis.Tarih = DateTime.Now;
            fis.FisNo = DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            var data = dbContext.Stok.ToList();
            Stok = new BindingList<Stok>(data);
            gridsatis.DataSource = Stok;
        }
        private void Ara_Click(object sender, EventArgs e)
        {


            string girilenbarkod = txtBarkod.Text;
            var arananUrun = dbContext.Stok.FirstOrDefault(stok => stok.Barkod == girilenbarkod);

            if (arananUrun != null)
            {
                
                List<Stok> urunListesi = gridsatis.DataSource as List<Stok>;

             
                if (urunListesi == null)
                {
                    urunListesi = new List<Stok>();
                }

                urunListesi.Add(arananUrun);
                gridsatis.DataSource = urunListesi;
                gridsatis.Refresh();
                gridsatis.RefreshDataSource();
            }
            else
            {
                MessageBox.Show("Ürün bulunamadı.");
            }
            

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*private void btnX_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int vırgul = tNumarator.Text.Count(x => x == ',');

                if (vırgul < 1)
                {
                    tNumarator.Text += b.Text;
                }
            }
            else if (b.Text == "x")
            {
                if (tNumarator.Text.Length > 0)
                {
                    tNumarator.Text = tNumarator.Text.Substring(0, tNumarator.Text.Length - 1);
                }

            }

            else
            {
                tNumarator.Text += b.Text;
            }


        }*/



        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmUrunEkle frmUrunEkle = new frmUrunEkle();
            frmUrunEkle.Show();
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmIslemSecme = Application.OpenForms[1];
            if (frmIslemSecme != null && frmIslemSecme is frmIslemSecme)
            {
                ((frmIslemSecme)frmIslemSecme).Show();
            }
        }

        private void UrunYazdırbutonu_Click(object sender, EventArgs e)
        {

            using (var context = new AppDbContext())
            {

                Button clickedButton = (Button)sender;
                string buttonName = clickedButton.Text;

                var EslesenUrun = context.Stok.FirstOrDefault(stok => stok.Ad == buttonName);

              

                if (EslesenUrun != null)
                {

                    List<Stok> urunListesi = gridsatis.DataSource as List<Stok>;


                    if (urunListesi == null)
                    {
                        urunListesi = new List<Stok>();
                    }

                    urunListesi.Add(EslesenUrun);
                    gridsatis.DataSource = urunListesi;
                    gridsatis.Refresh();
                    gridsatis.RefreshDataSource();
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.");
                }


            }


        }
        

    }


};