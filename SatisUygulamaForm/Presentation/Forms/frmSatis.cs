﻿using DevExpress.XtraEditors;
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

        private void SatisIslemi_Load(object sender, EventArgs e)
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
            #region Veri Nasıl Eklenir?
            #endregion
            AppDbContext db = new();
            //Urun urun = new()
            //{
            //    UrunAdi = "A Ürünü",
            //    Fiyat = 1000
            //};
            string girilenBarkod = tBarkod.Text;


            Stok arananUrun = db.Stok.FirstOrDefault(urun => urun.Barkod == girilenBarkod);

            if (arananUrun != null)
            {
                //fis.FisSatirlari.Add(new FisSatir
                //{
                //    Barkod = arananUrun.Barkod,
                //    BrFiyat = arananUrun.BrFiyat,
                //    Miktar = Convert.ToDecimal(tBarkod.Text),
                //    UrunAdi = arananUrun.ÜrünAdi,
                //    StokKodu = arananUrun.Barkod,
                //    Birimi = arananUrun.Birimi
                //});
                gridControl1.DataSource = fis.FisSatirlari;
                gridControl1.Refresh();
                gridControl1.RefreshDataSource();


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

        private void btnSalatalik_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "5";
        }

        private void btnTuvaletkagidi_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "6";
        }

        private void btnSut_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "3";
        }

        private void btnSilgi_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "2";
        }

        private void btnKalem_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "1";
        }


        private void enterDongusu(object sender, EventArgs e)
        {

        }



        private void btnDomates_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "4";
        }

        private void btnZeytin_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "7";
        }

        private void btnDefter_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "8";
        }

        private void btnKulaklik_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "9";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btncikolata_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "0";
        }

        private void btncay_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "11";
        }

        private void btnKolonya_Click(object sender, EventArgs e)
        {
            tBarkod.Text = "22";
        }



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

        private void btnUrunSil_Click(object sender, EventArgs e)
        {

        }

        private void Ara_Click_1(object sender, EventArgs e)
        {

        }
    }


};