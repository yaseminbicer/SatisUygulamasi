using HizliSatis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Domain.Entities
{
    public class Stok : BaseEntity

    {
        public string Barkod { get; set; }
        public string Ad { get; set; }
        public string Birim { get; set; }
        public string Aciklama { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public int KdvOrani { get; set; }
        public string UrunGrubu { get; set; }
       
    }

}
