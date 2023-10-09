using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisUygulamaForm
{
    public class Urun

    {
         public string Barkod { get; set; }
         public string ÜrünAdı { get; set; }
         public decimal BrFiyat { get; set; }
         public decimal Miktar { get; set; }
         public decimal GenelToplam { get; set; }
         public string Birimi {  get; set; }
         public object UrunList {  get; set; }

    }
    public class UrunList
    {
        public static List<Urun> urunListesi = new List<Urun>

        {
            new Urun { ÜrünAdı = "Kalem", Barkod = "1", BrFiyat = 38, Birimi = "Adet" },
            new Urun { ÜrünAdı = "Silgi", Barkod = "2", BrFiyat = 15, Birimi = "Adet" },
            new Urun { ÜrünAdı = "Süt", Barkod = "3", BrFiyat = 30, Birimi = "Litre" },
            new Urun { ÜrünAdı = "Domates", Barkod = "4", BrFiyat = 20, Birimi = "Kilogram" },
            new Urun { ÜrünAdı = "Salatalık", Barkod = "5", BrFiyat = 10, Birimi = "Kilogram" },
            new Urun { ÜrünAdı = "Tuvalet Kağıdı", Barkod = "6", BrFiyat = 199, Birimi = "Adet" },
            new Urun { ÜrünAdı = "Zeytin", Barkod = "7", BrFiyat = 10, Birimi = "Kilogram" },
            new Urun { ÜrünAdı = "Defter", Barkod = "8", BrFiyat = 42, Birimi = "Adet" },
            new Urun { ÜrünAdı = "Kulaklık", Barkod = "9", BrFiyat = 1000, Birimi = "Adet" },
            new Urun { ÜrünAdı = "Çikolata", Barkod = "0", BrFiyat = 9, Birimi = "Adet" },
            new Urun { ÜrünAdı = "Çay", Barkod = "11", BrFiyat = 80, Birimi = "Paket" },
            new Urun { ÜrünAdı = "Kolonya", Barkod = "22", BrFiyat = 120, Birimi = "Şişe" },

        };
       
    }
}

