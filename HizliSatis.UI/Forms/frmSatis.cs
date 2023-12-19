using DevExpress.XtraEditors;
using HizliSatis.Application.Abstract;
using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly IRepository<Stok> _repository;
        BindingList<Stok> Stok { get; set; }
        Fis fis = new Fis();

        public frmSatis(IRepository<Stok> repository)
        {
            InitializeComponent();
            fis.Tarih = DateTime.Now;
            fis.FisNo = DateTime.Now.ToString("yyyyMMddHHmmss");
            _repository = repository;
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            var data = _repository.GetAllList();
            Stok = new BindingList<Stok>(data);
            gridsatis.DataSource = Stok;
        }
        private void Ara_Click(object sender, EventArgs e)
        {


            string girilenbarkod = txtBarkod.Text;
            Stok arananUrun = _repository.GetByFilter(stok => stok.Barkod == girilenbarkod);

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
            var frmUrunEkle = Program.ServiceProvider.GetRequiredService<frmUrunEkle>();
            frmUrunEkle.Show();
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FrmIslemSecme = System.Windows.Forms.Application.OpenForms[nameof(frmIslemSecme)];
            if (FrmIslemSecme != null && FrmIslemSecme is frmIslemSecme)
            {
                ((frmIslemSecme)FrmIslemSecme).Show();
            }
        }

        private void UrunYazdırbutonu_Click(object sender, EventArgs e)
        {
            {
                Button clickedButton = (Button)sender;
                string buttonName = clickedButton.Text;

                var EslesenUrun = _repository.GetByFilter(stok => stok.Ad == buttonName);



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