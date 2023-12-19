using HizliSatis.Application.Abstract;
using HizliSatis.Application.Abstractions;
using HizliSatis.Application.Concretes;
using HizliSatis.Persistence.Concretes;
using HizliSatis.Persistence.Context;
using HizliSatis.UI.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Client;

namespace HizliSatis.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static IServiceProvider ServiceProvider;
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

                services.AddDbContext<AppDbContext>(opt =>
                {
                    opt.UseSqlServer("Server=.\\SQLEXPRESS; Database=HizliSatis;TrustServerCertificate=True; integrated security= true");
                });
                services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
                services.AddTransient(typeof(frmLogin));
                services.AddTransient(typeof(frmKartEkle));
                services.AddTransient(typeof(frmKullanicilar));
                services.AddTransient(typeof(frmMusteriler));
                services.AddTransient(typeof(frmSatis));
                services.AddTransient(typeof(frmStokListesi));
                services.AddTransient(typeof(frmStokListesiDetay));
                services.AddTransient(typeof(frmStokTakibi));
                services.AddTransient(typeof(frmUrunEkle));
                services.AddTransient(typeof(frmIslemSecme));
                ServiceProvider = services.BuildServiceProvider();
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            var frmLogin = ServiceProvider.GetRequiredService<frmLogin>();
            System.Windows.Forms.Application.Run(frmLogin);

        }

    }
}