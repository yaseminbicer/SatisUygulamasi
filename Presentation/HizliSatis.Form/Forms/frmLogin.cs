using DevExpress.DataAccess.Native.Web;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;
using DevExpress.XtraRichEdit.Import.OpenXml;
using DevExpress.CodeParser;
using SatisUygulamaForm.Persistence;
using SatisUygulamaForm.Domain.Entity;
using DevExpress.XtraScheduler.iCalendar.Components;

namespace HizliSatis.Form.Forms
{
    public partial class frmLogin : XtraForm
    {
        AppDbContext dbContext = new AppDbContext();
        public frmLogin()
        {
            InitializeComponent();
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
                frmIslemSecme frm = new frmIslemSecme();
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
            var kullanici = dbContext.Kullanici.FirstOrDefault(s => s.KullaniciAdi == kullaniciAdi && s.Sifre == sifre);
            return kullanici != null;
        }

        private void KullanicilariOlustur()
        {
            try
            {
                var kullanicilar = dbContext.Kullanici.ToList();
                if (!kullanicilar.Any())
                {
                    var kullanici = new Kullanici();
                    kullanici.KullaniciAdi = "admin";
                    kullanici.Sifre = "admin1";
                    kullanici.AdSoyad = "Yönetici";
                    kullanici.Yonetici = true;
                    dbContext.Add(kullanici);
                    dbContext.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

