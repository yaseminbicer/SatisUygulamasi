using DevExpress.XtraEditors;
using HizliSatis.Application.Abstract;
using HizliSatis.Application.Concretes;
using HizliSatis.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;


namespace HizliSatis.UI.Forms
{
    public partial class frmLogin : XtraForm
    {
        private readonly IAccountService _accountService;
        public frmLogin(IAccountService AccountService)
        {
            InitializeComponent();
            _accountService = AccountService;
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
            if (GirisYap(kullaniciadi, sifre))
            {
                this.Hide();
                var _frmIslemSecme = Program.ServiceProvider.GetRequiredService<frmIslemSecme>();
                _frmIslemSecme.Show();
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

            var kullanici = _accountService.AuthenticateUser(kullaniciAdi, sifre);
            return kullanici != null;
        }

        private void KullanicilariOlustur()
        {
            try
            {
                var kullanicilar = _accountService.GetUsers();
                if (!kullanicilar.Any())
                {
                    var kullanici = new Kullanici();
                    kullanici.KullaniciAdi = "admin";
                    kullanici.Sifre = "admin1";
                    kullanici.AdSoyad = "Yönetici";
                    kullanici.Yonetici = true;
                    _accountService.AddUser(kullanici);
                    _accountService.SaveChanges();
                    //var form = Program.ServiceProvider.GetRequiredService<frmKullanicilar>();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       

        private void hccExit_ElementMouseClick(object sender, DevExpress.Utils.Html.DxHtmlElementMouseEventArgs e)
        {
            if (e.ElementId == "close") System.Windows.Forms.Application.Exit();
        }
    }
}

