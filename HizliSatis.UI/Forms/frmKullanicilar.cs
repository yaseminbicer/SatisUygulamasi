using DevExpress.XtraEditors;
using HizliSatis.Application.Abstract;
using HizliSatis.Application.Abstractions;
using HizliSatis.Application.Concretes;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Concretes;
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
    public partial class frmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        private readonly IAccountService _accountService;

        public frmKullanicilar(IAccountService AccountService)
        {
            _accountService = AccountService;

        }
        public frmKullanicilar()
        {
            InitializeComponent();
        }
      
        BindingList<Kullanici> Kullanicilar { get; set; }
        

        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            var data = _accountService.GetUsers();
            Kullanicilar = new BindingList<Kullanici>(data);
            gridKullanici.DataSource = Kullanicilar;
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (var kullanici in Kullanicilar.Where(s => s.Id == 0))
            {
                _accountService.AddUser(kullanici);
                
            }
            _accountService.SaveChanges();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var kullanici = (Kullanici)viewKullanici.GetFocusedRow();
            _accountService.RemoveUser(kullanici);
            viewKullanici.DeleteRow(viewKullanici.FocusedRowHandle);
        }

        private void gridKullanici_Click(object sender, EventArgs e)
        {

        }
    }
}