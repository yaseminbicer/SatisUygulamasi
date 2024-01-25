using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using HizliSatis.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace HizliSatis.Persistence.Context
{

    public class AppDbContext:DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    

        public DbSet<Fis> Fis { get; set; }
        public DbSet<FisSatir> FisSatir { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Stok> Stok { get; set; }
        public DbSet<Kategori> Kategori { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=HizliSatis;TrustServerCertificate=True; integrated security= true");
        }
    }


}