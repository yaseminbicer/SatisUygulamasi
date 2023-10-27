using DevExpress.DataAccess.Native.Web;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;
using DevExpress.XtraRichEdit.Import.OpenXml;
using DevExpress.CodeParser;

namespace SatisUygulamaForm
{
    public partial class frmLogin : XtraForm
    {

        public frmLogin()
        {
            InitializeComponent();


        }



        static RegistryKey BaseFolderPath = Registry.CurrentUser;
        static string SubFolderPath = "KullaniciGirisBilgileri";
        static string KullaniciAdi = "KullaniciAdiKey";
        static string Sifre = "SifreKey";

        public static void Registry_yaz(string txtKullaniciAdi, string txtSifre)
        {
            RegistryKey RegKey = BaseFolderPath;
            RegistryKey SubKey = RegKey.CreateSubKey(SubFolderPath);

            SubKey.SetValue(KullaniciAdi, txtKullaniciAdi);
            SubKey.SetValue(Sifre, txtSifre);
        }
        public static string Registry_oku(string key)
        {
            RegistryKey RegKey = BaseFolderPath;
            RegistryKey SubKey = RegKey.OpenSubKey(SubFolderPath);

            return SubKey == null ? "" : SubKey.GetValue(key).ToString();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {


            txtKullaniciAdi.Text = Registry_oku(KullaniciAdi);
            txtSifre.Text = Registry_oku(Sifre);




        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (kullaniciadi == "admin" && sifre == "admin1")
            {

                this.Hide();
                frmIslemSecme frm = new frmIslemSecme();
                frm.Show();
            }
            else
            {
                label5.Show();
            }



        }

        private void chkbtnBeniHatirla_CheckedChanged(object sender, EventArgs e)
        {

            if (chkbtnBeniHatirla.Checked == true)
            {
                Registry_yaz(txtKullaniciAdi.Text.ToString(), txtSifre.Text.ToString());
            }
            else
            {
                Registry.CurrentUser.DeleteValue("KullaniciGirisBilgileri");
            }

            /* if (chkbtnBeniHatirla.Checked == true)
             {
                 txtKullaniciAdi.Text = Registry_oku();
                 txtSifre.Text = Registry_oku();
             }
             */
        }

        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {

        }
    }
}

