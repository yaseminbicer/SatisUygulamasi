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


    }
    public class UrunList
    {
        public static List<Urun> urunListesi = new List<Urun>

        {
            new Urun { ÜrünAdi = "Kalem", Barkod = "1", BrFiyat = 38, Birimi = "Adet" },
            new Urun { ÜrünAdi = "Silgi", Barkod = "2", BrFiyat = 15, Birimi = "Adet" },
            new Urun { ÜrünAdi = "Süt", Barkod = "3", BrFiyat = 30, Birimi = "Litre" },
            new Urun { ÜrünAdi = "Domates", Barkod = "4", BrFiyat = 20, Birimi = "Kilogram" },
            new Urun { ÜrünAdi = "Salatalık", Barkod = "5", BrFiyat = 10, Birimi = "Kilogram" },
            new Urun { ÜrünAdi = "Tuvalet Kağıdı", Barkod = "6", BrFiyat = 199, Birimi = "Adet" },
            new Urun { ÜrünAdi = "Zeytin", Barkod = "7", BrFiyat = 10, Birimi = "Kilogram" },
            new Urun { ÜrünAdi = "Defter", Barkod = "8", BrFiyat = 42, Birimi = "Adet" },
            new Urun { ÜrünAdi = "Kulaklık", Barkod = "9", BrFiyat = 1000, Birimi = "Adet" },
            new Urun { ÜrünAdi = "Çikolata", Barkod = "0", BrFiyat = 9, Birimi = "Adet" },
            new Urun { ÜrünAdi = "Çay", Barkod = "11", BrFiyat = 80, Birimi = "Paket" },
            new Urun { ÜrünAdi = "Kolonya", Barkod = "22", BrFiyat = 120, Birimi = "Şişe" },

        };
       
    }
}

