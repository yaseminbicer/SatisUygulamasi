using HizliSatis.Application.Abstract;
using HizliSatis.Application.Abstractions;
using HizliSatis.Application.Concretes;
using HizliSatis.Persistence.Concretes;
using HizliSatis.Persistence.Context;
using HizliSatis.UI.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace HizliSatis.UI
{
    public static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }
        [STAThread]
     
        static void Main()
        {
         
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(opt => { opt.UseSqlServer("Server=.\\SQLEXPRESS; Database=HizliSatis;TrustServerCertificate=True; integrated security= true"); }); ; ;

            services.AddTransient(typeof(IAccountService), typeof(AccountService));
            services.AddTransient(typeof(ICustomerService), typeof(CustomerService));
            services.AddTransient(typeof(IProductService), typeof(ProductService));
            services.AddTransient(typeof(frmKullanicilar));
            services.AddTransient(typeof(frmIslemSecme));
            services.AddTransient(typeof(frmKartEkle));
            services.AddTransient(typeof(frmLogin));
            services.AddTransient(typeof(frmMusteriler));
            services.AddTransient(typeof(frmSatis));
            services.AddTransient(typeof(frmStokListesi));
            services.AddTransient(typeof(frmStokListesiDetay));
            services.AddTransient(typeof(frmStokTakibi));
            services.AddTransient(typeof(frmUrunEkle));
            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var frmLogin = ServiceProvider.GetRequiredService<frmLogin>();
        
            
            System.Windows.Forms.Application.Run(frmLogin);

           

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

        }
      
        
    }
}