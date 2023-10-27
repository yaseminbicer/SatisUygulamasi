using DevExpress.Xpo;
using SatisUygulamaForm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisUygulamaForm
{
    public class FisSatir:BaseEntity
    {
        [ForeignKey(nameof(Fis))]
        public int FisId { get; set; }
        [ForeignKey(nameof(Stok))]
        public int StokId { get; set; }
        public decimal Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Iskonto { get; set; }
        public decimal Tutar => Miktar * BirimFiyat;
        public virtual Fis Fis { get; set; }
        public virtual Stok Stok { get; set; }
    }
}
