using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure; 
namespace SatisUygulamaForm.Persistence
{





    #region context.AddAsync Fonksiyonu
    //await context.AddAsync(urun);
    #endregion
    #region context.DbSet.AddAsync Fonksiyonu
    //await context.Urunler.AddAsync(urun);
    #endregion

    //await context.SaveChangesAsync(); 

    //SaveChanges Nedir?
    //SaveChanges; insert, update ve delete sorgularını oluşturup bir transaction eşliğinde veritabanına gönderip execute eden fonksiyodur. Eğer ki oluşturulan sorgulardan herhangi biri başarısız olursa tüm işlemleri geri alır(rollback)

    #region EF Core Açısından Bir Verinin Eklenmesi Gerektiği Nasıl Anlaşılıyor?
    //init context = new();
    //Urun urun = new()
    //{
    //    UrunAdi = "B ürünü",
    //    Fiyat = 2000
    //};

    //Console.WriteLine(context.Entry(urun).State );

    //await context.AddAsync(urun);

    //Console.WriteLine(context.Entry(urun).State);

    //await context.SaveChangesAsync();

    //Console.WriteLine(context.Entry(urun).State);
    #endregion
    
    #region SaveChanges'ı Verimli Kullanalım!
    //SaveChanges fonksiyonu her tetiklendiğinde bir transaction oluşituracağından dolayı EF Core ile yapılan her bir işleme özel kullanmaktan kaçınmalıyız! Çünkü her işleme özel transaction veritaanı açısından ekstradan maliyet demektir. O yüzden mümkün mertebe tüm işlemlerimizi tek bir transaction eşliğinde veritabanına gönderebilmek için savechanges'ı aşağıdaki gibi tek seferde kullanmak hem maliyet hem de yönetilebilirlik açısından katkıda bulunmuş olacaktır.

    //init context = new();
    //Urun urun1 = new()
    //{
    //    UrunAdi = "C ürünü",
    //    Fiyat = 2000
    //};
    //Urun urun2 = new()
    //{
    //    UrunAdi = "D ürünü",
    //    Fiyat = 2000
    //};
    //Urun urun3 = new()
    //{
    //    UrunAdi = "E ürünü",
    //    Fiyat = 2000
    //};

    //await context.AddAsync(urun1);

    //await context.AddAsync(urun2);

    //await context.AddAsync(urun3);
    //await context.SaveChangesAsync();
    #endregion
    #region AddRange
    //init context = new();
    //Urun urun1 = new()
    //{
    //    UrunAdi = "C ürünü",
    //    Fiyat = 2000
    //};
    //Urun urun2 = new()
    //{
    //    UrunAdi = "D ürünü",
    //    Fiyat = 2000
    //};
    //Urun urun3 = new()
    //{
    //    UrunAdi = "E ürünü",
    //    Fiyat = 2000
    //};
    //await context.Urunler.AddRangeAsync(urun1, urun2, urun3);
    //await context.SaveChangesAsync();
    #endregion
    

    #region Eklenen Verinin Generate Edilen Id'sini Elde Etme
    //init context = new();
    //Urun urun = new()
    //{
    //    UrunAdi = "O ürünü",
    //    Fiyat = 2000
    //};
    //await context.AddAsync(urun);
    //await context.SaveChangesAsync();
    //Console.WriteLine(urun.Id);
    #endregion  








    #region Veri Nasıl Güncellenir?
    //init context = new();

    //Urun urun = await context.Urunler.FirstOrDefaultAsync(u => u.Id == 3);
    //urun.UrunAdi = "H Ürünü";
    //urun.Fiyat = 999;

    //await context.SaveChangesAsync();
    #endregion
    #region ChangeTracker Nedir? Kısaca!
    //ChangeTracker, context üzerinden gelen verilerin takibinden sorumlu bir mekanizmadır. Bu takip mekanizması sayesinde context üzerinden gelen verilerle ilgili işlemler neticesinde update yahut delete sorgularının oluşturulacağı anlaşılır!
    #endregion
    #region Takip Edilmeyen Nesneler Nasıl Güncellenir?
    //init context = new();
    //Urun urun = new()
    //{
    //    Id = 3,
    //    UrunAdi = "Yeni Ürün",
    //    Fiyat = 123
    //};
    #endregion
    #region Update Fonksiyonu
    //ChangeTracker mekanizması tarafından takip edilmeyen nesnelerin güncellenebilmesi için Update fonksiyonu kullanılır!
    //Update fonksiyonunu kullanabilmek için kesinlikle ilgili nesnede Id değeri verilmelidir! Bu değer güncellenecek(update sorgusu oluşturulacak) verinin hangisi olduğunu ifade edecektir.
    //context.Urunler.Update(urun);
    //await context.SaveChangesAsync();
    #endregion

    #region EntityState Nedir?
    //Bir entity instance'ının durumunu ifade eden bir referanstır.
    //init context = new();
    //Urun u = new();
    //Console.WriteLine(context.Entry(u).State);
    #endregion
    #region EF Core Açısından Bir Verinin Güncellenmesi Gerektiği Nasıl Anlaşılıyor?
    //init context = new();
    //Urun urun = await context.Urunler.FirstOrDefaultAsync(u => u.Id == 3);
    //Console.WriteLine(context.Entry(urun).State);

    //urun.UrunAdi = "Hilmi";

    //Console.WriteLine(context.Entry(urun).State);

    //await context.SaveChangesAsync();

    //Console.WriteLine(context.Entry(urun).State);

    //urun.Fiyat = 999;

    //Console.WriteLine(context.Entry(urun).State);
    #endregion
    #region Birden Fazla Veri Güncellenirken Nelere Dikkat Edilmelidir?
    //init context = new();
    //
    //var urunler = await context.Urunler.ToListAsync();
    //foreach (var urun in urunler)
    //{
    //urun.UrunAdi += "*";
    //}
    //
    //await context.SaveChangesAsync();
    #endregion

    public class AppDbContext:DbContext
    {
      
        public DbSet<Urun> Urun { get; set; } = null!;
        public DbSet<Fis> Fis { get; set; } = null!;
        public DbSet<FisSatir> FisSatir { get; set; } = null!;
       
     
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ISTMKRMSL39181; Database=HizliSatis;  TrustServerCertificate=True; integrated security= true");
        }
    }


}