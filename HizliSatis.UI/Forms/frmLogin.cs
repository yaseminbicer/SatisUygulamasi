using DevExpress.XtraEditors;
using HizliSatis.Application.Abstract;
using HizliSatis.Application.Concretes;
using HizliSatis.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using Microsoft.Win32;

namespace HizliSatis.UI.Forms
{
    public partial class frmLogin : XtraForm
    {
        private readonly IRepository<Kullanici> _repository;

        public frmLogin(IRepository<Kullanici> repository)
        {
            InitializeComponent();
            _repository = repository;
            KullanicilariOlustur();
        }


        private RegistryKey BaseFolderPath = Registry.CurrentUser;
        private string SubFolderPath = "KullaniciGirisBilgileri";
        private string KullaniciAdi = "KullaniciAdiKey";
        private string Sifre = "SifreKey";

        public void RegistryYaz(string kullaniciAdi, string sifre)
        {
            RegistryKey RegKey = BaseFolderPath;
            RegistryKey SubKey = RegKey.CreateSubKey(SubFolderPath);
            SubKey.SetValue(KullaniciAdi, kullaniciAdi);
            SubKey.SetValue(Sifre, sifre);
        }
        public string RegistryOku(string key)
        {
            RegistryKey RegKey = BaseFolderPath;
            RegistryKey SubKey = RegKey.OpenSubKey(SubFolderPath);
            return SubKey == null ? "" : SubKey.GetValue(key).ToString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = RegistryOku(KullaniciAdi);
            txtSifre.Text = RegistryOku(Sifre);
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            if ( GirisYap(kullaniciadi, sifre))
            {
                this.Hide();
                var frm = Program.ServiceProvider.GetRequiredService<frmIslemSecme>();
                frm.Show();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı bilgileri hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void chkbtnBeniHatirla_CheckedChanged(object sender, EventArgs e)
        {

            if (chkbtnBeniHatirla.Checked == true)
            {
                RegistryYaz(txtKullaniciAdi.Text, txtSifre.Text);
            }
            else
            {
                Registry.CurrentUser.DeleteValue("KullaniciGirisBilgileri");
            }
        }

        private bool GirisYap(string kullaniciAdi, string sifre)
        {
            var kullanici = _repository.GetByFilter(s => s.KullaniciAdi == kullaniciAdi && s.Sifre == sifre);
            return kullanici != null;
        }

        private void KullanicilariOlustur()
        {
            try
            {
                var kullanicilar = _repository.GetAllList();
                if (!kullanicilar.Any())
                {
                    var kullanici = new Kullanici();
                    kullanici.KullaniciAdi = "admin";
                    kullanici.Sifre = "admin1";
                    kullanici.AdSoyad = "Yönetici";
                    kullanici.Yonetici = true;
                    _repository.Create(kullanici);
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

