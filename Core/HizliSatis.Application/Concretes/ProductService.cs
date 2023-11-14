using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Context;
using Microsoft.EntityFrameworkCore;
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
        public void AddProduct(Stok product)
        {
            dbContext.Add(product);
            SaveChanges();
        }
        public void RemoveProduct(Stok product)
        {
            dbContext.Remove(product);
            dbContext.SaveChanges();

        }
        public Stok UpdateProduct(int id)
        {
            var guncellenecekStok = dbContext.Stok.Find(id);

            if (guncellenecekStok != null)
            {
                
                dbContext.SaveChanges();
            }

            return guncellenecekStok;
            
        }
        public Stok GetStokById(int id)
        {
            var stok = dbContext.Stok.FirstOrDefault(p => p.Id == id);
            return stok;
        }
        public Stok GetStokByAd(string ad)
        {
            return dbContext.Stok.FirstOrDefault(stok => stok.Ad == ad);
        }
        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }
    }
}
