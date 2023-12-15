using HizliSatis.UI.Forms;
using HizliSatis.Application;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HizliSatis.Application.Abstract;
using HizliSatis.Application.Concretes;
using HizliSatis.Application.Abstractions;
using HizliSatis.Persistence.Concretes;
using DevExpress.XtraReports.Design;
using System.Reflection;
using Microsoft.Identity.Client;
using HizliSatis.Persistence.Context;
using DevExpress.XtraRichEdit.Import.OpenXml;

namespace HizliSatis.UI
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //Register Services
            //ServiceMiddlware.RegisterServices();

            //ConfigureServices(services);
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

            var frmLogin = ServiceProvider.GetRequiredService<frmLogin>();
   
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(frmLogin);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

        }
        public static ServiceProvider ServiceProvider { get; private set; }

        
    }
}