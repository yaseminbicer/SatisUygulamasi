using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Domain.Entities
{
    public class Kategori: BaseEntity
    {
        public string KategoriAdi { get; set; }
        public string PluAdi { get; set; }
        public string Barkod { get; set; }
        public decimal Fiyat { get; set; }
    }
}
