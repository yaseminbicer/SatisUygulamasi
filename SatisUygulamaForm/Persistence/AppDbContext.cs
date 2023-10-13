using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisUygulamaForm.Persistence
{
    public class AppDbContext:DbContext
    {
        public DbSet<Urun> Urun {get; set;}
        public DbSet<Fis> Fis { get; set;}
        public DbSet<FisSatir> FisSatir { get; set;}
    }
}
