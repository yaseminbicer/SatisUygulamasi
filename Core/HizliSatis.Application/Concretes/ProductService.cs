using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext dbContext=new AppDbContext();
        public List<Stok> GetProducts()
        {
            return dbContext.Stok.ToList();
        }
    }
}
