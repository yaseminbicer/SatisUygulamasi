using HizliSatis.Application.Abstractions;
using HizliSatis.Persistence.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace HizliSatis.UI.Forms
{
    public partial class frmSatisnew : DevExpress.XtraEditors.XtraForm
    {
        private readonly IProductService _productService;


        public frmSatisnew()
        {
            InitializeComponent();
            
        }

       

    }
}
