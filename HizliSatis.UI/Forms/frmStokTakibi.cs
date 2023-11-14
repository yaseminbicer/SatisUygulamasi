namespace HizliSatis.UI.Forms
{
    public partial class frmStokTakibi : DevExpress.XtraEditors.XtraForm
    {
        public frmStokTakibi()
        {
            InitializeComponent();
        }

        private void btnKartEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKartEkle KartEkle = new frmKartEkle();
            KartEkle.Show();
        }

    }
}