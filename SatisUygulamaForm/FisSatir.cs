using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisUygulamaForm
{
    public class FisSatir
    {
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string Barkod { get; set; }
        public string Birim { get; set; }
        public decimal Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar => Miktar * BirimFiyat;
    }
}
