using DevExpress.XtraEditors;
using HizliSatis.Application.Abstract;
using HizliSatis.Application.Concretes;
using HizliSatis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HizliSatis.UI.Forms
{
    public partial class ucKategoriTanimlama : DevExpress.XtraEditors.XtraUserControl
    {
        public ucKategoriTanimlama()
        {
            InitializeComponent();
        }
        private readonly ICategoryService _categoryService;

        public ucKategoriTanimlama(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }
        private void LoadData()
        {
            gridCategory.DataSource = _categoryService.GetCategory();
        }

        BindingList<Kategori> Kategoriler { get; set; }


        private void ucKategoriTanimlama_Load(object sender, EventArgs e)
        {
            var category = _categoryService.GetCategory();
            Kategoriler = new BindingList<Kategori>(category);
            gridCategory.DataSource = Kategoriler;
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (var kategori in Kategoriler.Where(s => s.Id == 0))
            {
                _categoryService.AddCategory(kategori);

            }
            _categoryService.SaveChanges();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var kategori = (Kategori)ViewCategory.GetFocusedRow();
            _categoryService.RemoveCategory(kategori);
            ViewCategory.DeleteRow(ViewCategory.FocusedRowHandle);
        }
    }
}
