using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisUygulamaForm
{
    public class Fis
    {

        public Fis()
        {
            FisSatirlari = new List<FisSatir>();
        }
        public DateTime Tarih { get; set; }
        public string MusteriAdi { get; set; }
        public string FisNo { get; set; }

        public List<FisSatir> FisSatirlari { get; set; }
    }
}
