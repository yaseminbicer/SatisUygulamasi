using DevExpress.XtraEditors;
using HizliSatis.Application.Abstract;
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
    public partial class ucKullanicilar : DevExpress.XtraEditors.XtraUserControl
    {
        BindingList<Kullanici> Kullanicilar { get; set; }
        private readonly IAccountService _accountService;

            public ucKullanicilar(IAccountService AccountService)
            {
                InitializeComponent();
                _accountService = AccountService;

            }



            private void ucKullanicilar_Load(object sender, EventArgs e)
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


    }
}

