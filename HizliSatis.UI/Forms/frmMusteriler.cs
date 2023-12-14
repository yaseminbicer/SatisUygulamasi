using HizliSatis.Application.Abstract;
using HizliSatis.Application.Concretes;
using HizliSatis.Domain.Entities;
using System.ComponentModel;
using System.Data;

namespace HizliSatis.UI.Forms
{
    public partial class frmMusteriler : DevExpress.XtraEditors.XtraForm
    {

        private readonly ICustomerService _CustomerService;
        
        public frmMusteriler(ICustomerService CustomerService)
        {
            _CustomerService = CustomerService;

            InitializeComponent();
        }

       
        BindingList<Musteri> Musteriler { get; set; }
        public frmMusteriler()
        {
            InitializeComponent();

        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            
            var data = _CustomerService.GetCustomer();
            Musteriler = new BindingList<Musteri>(data);
            gridMusteri.DataSource = Musteriler;
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            foreach (var Musteri in Musteriler.Where(s => s.Id == 0))
            {
                _CustomerService.AddCustomer(Musteri);
            }
            int result = _CustomerService.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var musteri = (Musteri)viewMusteri.GetFocusedRow();
            _CustomerService.RemoveCustomer(musteri);
            viewMusteri.DeleteRow(viewMusteri.FocusedRowHandle);

        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
            new frmIslemSecme().Show();

        }
    }
}
