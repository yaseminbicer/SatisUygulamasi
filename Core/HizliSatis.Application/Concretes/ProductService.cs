using HizliSatis.Application.Abstract;
using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly AppDbContext _dbContext;

        public ProductService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Stok> GetProducts()
        {
            return _dbContext.Stok.ToList();
        }
        public void AddProduct(Stok product)
        {
            _dbContext.Add(product);
            SaveChanges();
        }
        public void RemoveProduct(Stok product)
        {
            _dbContext.Remove(product);
           SaveChanges();

        }
        public Stok UpdateProduct(int id)
        {
            var guncellenecekStok = _dbContext.Stok.Find(id);

            if (guncellenecekStok != null)
            {
                SaveChanges();
            }

            return guncellenecekStok;
            
        }
        public Stok GetStokById(int id)
        {
            var stok = _dbContext.Stok.FirstOrDefault(p => p.Id == id);
            return stok;
        }
        public Stok GetStokByName(string ad)
        {
            return _dbContext.Stok.FirstOrDefault(stok => stok.Ad == ad);
        }
        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

    }
}
