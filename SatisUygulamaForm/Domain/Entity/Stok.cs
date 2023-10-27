using Microsoft.Identity.Client;
using SatisUygulamaForm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisUygulamaForm
{
    public class Stok : BaseEntity

    {
        public string Barkod { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public decimal BirimFiyat { get; set; }
        public string Birim { get; set; }
        public string Aciklama { get; set; }
        public double AlisFiyati { get; set; }
        public double SatisFiyati { get; set; }
        public int KdvOrani { get; set; }

    }

}
