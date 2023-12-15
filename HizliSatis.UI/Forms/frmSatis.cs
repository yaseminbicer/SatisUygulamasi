using DevExpress.XtraEditors;
using DevExpress.XtraEditors;
using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace HizliSatis.UI.Forms
{
    public partial class frmSatis : Form
    {
        private readonly IProductService _productService;

        public frmSatis(IProductService productService)
        {
            InitializeComponent();
            _fis.Tarih = DateTime.Now;
            _fis.FisNo = DateTime.Now.ToString("yyyyMMddHHmmss");
            _productService = productService;
        }
       
        BindingList<Stok> Stok { get; set; }
        Fis _fis = new Fis();
       

        private void frmSatis_Load(object sender, EventArgs e)
        {
            var data = _productService.GetProducts();
            Stok = new BindingList<Stok>(data);
            gridsatis.DataSource = Stok;
        }
        private void Ara_Click(object sender, EventArgs e)
        {

            string girilenbarkod = txtBarkod.Text;
            var arananUrun = _productService.GetStokByName(girilenbarkod);

            if (arananUrun != null)
            {

                List<Stok> urunListesi = (List<Stok>)gridsatis.DataSource;


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


        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmUrunEkle frmUrunEkle = new frmUrunEkle();
            frmUrunEkle.Show();
        }
        

        private void UrunYazdırbutonu_Click(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;
            string buttonName = clickedButton.Text;

            var EslesenUrun = _productService.GetStokByName(buttonName);

            if (EslesenUrun != null)
            {

                List<Stok> urunListesi = (List<Stok>)gridsatis.DataSource;


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

        private void frmSatis_FormClosed(object sender, FormClosedEventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var IslemSecme = System.Windows.Forms.Application.OpenForms[1];
            if (IslemSecme != null && IslemSecme is frmIslemSecme)
            {
                IslemSecme.Show();
            }
        }
    }


};