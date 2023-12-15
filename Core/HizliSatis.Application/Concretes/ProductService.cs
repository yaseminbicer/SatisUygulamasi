using HizliSatis.Application.Abstractions;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace HizliSatis.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _dbContext = new AppDbContext();

        public ProductService()
        {
        }

        public ProductService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddProduct(Stok stok)
        {
            _dbContext.Add(stok);
            SaveChanges();
        }

        public Stok GetProductByFilter(Expression<Func<Stok, bool>> filter)
        {
            return _dbContext.Stok.FirstOrDefault(filter);
        }

        public Stok GetProductById(int id)
        {
            return _dbContext.Stok.Find(id);
        }

        public List<Stok> GetProducts()
        {
            return _dbContext.Stok.ToList();
        }

        public void RemoveProduct(Stok stok)
        {
            _dbContext.Remove(stok);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Update(Stok stok)
        {
            _dbContext.Update(stok);
            SaveChanges();
        }
    }

}