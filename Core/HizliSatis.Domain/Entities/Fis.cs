using HizliSatis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Domain.Entities
{
    public class Fis: BaseEntity
    {

        public Fis()
        {
            FisSatirlari = new HashSet<FisSatir>();
        }

        public DateTime Tarih { get; set; }
        public string MusteriAdi { get; set; }
        public string FisNo { get; set; }

        [ForeignKey(nameof(Musteri))]
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }
        public ICollection<FisSatir> FisSatirlari { get; set; }
    }
}
