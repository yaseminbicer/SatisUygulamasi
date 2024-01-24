using HizliSatis.Application.Abstract;
using HizliSatis.Application.Abstractions;
using HizliSatis.Application.Concretes;
using HizliSatis.Application.Extensions;
using HizliSatis.Application.MiddleWares;
using HizliSatis.Persistence.Concretes;
using HizliSatis.Persistence.Context;
using HizliSatis.UI.Forms;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

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
            services.AddTransient(typeof(frmIslemSecme));
            services.AddTransient(typeof(frmKartEkle));
            services.AddTransient(typeof(frmLogin));
            services.AddTransient(typeof(frmMusteriler));
            services.AddTransient(typeof(frmSatis));
            services.AddTransient(typeof(frmStokListesi));
            services.AddTransient(typeof(frmStokListesiDetay));
            services.AddTransient(typeof(frmStokTakibi));
            services.AddTransient(typeof(ucKullanicilar));
            services.AddTransient(typeof(ucStok));
            services.AddTransient(typeof(frmSatisnew));
            services.AddTransient(typeof(frmAnaMenu));
            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var frmLogin = ServiceProvider.GetRequiredService<frmLogin>();


            System.Windows.Forms.Application.Run(frmLogin);

            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

        }
        public static void Configure(IApplicationBuilder app)
        {
           
            app.Use(async (context, next) =>
            {
                
                await next.Invoke();
            });
           
            
            app.UseServiceMiddleware();
            
           
        } 
      
        
    }
}