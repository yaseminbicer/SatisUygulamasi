using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisUygulamaForm
{
    public class Urun : Fis

    {
         public string Barkod { get; set; }
         public string ÜrünAdi { get; set; }
         public decimal BrFiyat { get; set; }
         public decimal Miktar { get; set; }
         public decimal GenelToplam { get; set; }
         public string Birimi {  get; set; }
         public object UrunList {  get; set; }
        public string Aciklama { get; set; }
        public string UrunGrup {  get; set; }
        public double AlisFiyati {  get; set; }
        public double SatisFiyati { get; set; }
        public int KdvOrani {  get; set; }
        public string UrunAciklama { get; set; }

        public string UrunGrubu {  get; set; }

    }
    
    }
