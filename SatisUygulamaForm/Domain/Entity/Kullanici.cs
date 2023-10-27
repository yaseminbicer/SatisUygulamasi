using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisUygulamaForm.Domain.Entity
{
    public class Kullanici : BaseEntity
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string AdSoyad { get; set; }
        public bool Yonetici { get; set; }
    }
}
