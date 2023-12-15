using DevExpress.Data.Utils;
using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace HizliSatis.UI.Forms
{
    public partial class frmStokTakibi : DevExpress.XtraEditors.XtraForm
    {
        private readonly IProductService _productService;
      
        public frmStokTakibi(IProductService ProductService)
        {
            InitializeComponent();
            _productService = ProductService;
        }
       

        private void btnKartEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            var _frmKartEkle = Program.ServiceProvider.GetRequiredService<frmKartEkle>();
            _frmKartEkle.Show();
        }

    }
}