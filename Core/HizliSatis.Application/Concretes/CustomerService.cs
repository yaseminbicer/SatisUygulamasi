using HizliSatis.Application.Abstract;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.Concretes
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _dbContext = new AppDbContext();

        public CustomerService()
        {
        }

        public CustomerService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddCustomer(Musteri musteri)
        {
            _dbContext.Musteri.Add(musteri);
            SaveChanges();
        }

        public Musteri GetCustomerByFilter(Expression<Func<Musteri, bool>> filter)
        {
           return _dbContext.Musteri.FirstOrDefault(filter);
        }

        public Musteri GetCustomerById(int id)
        {
            return _dbContext.Musteri.Find(id);
        }

        public List<Musteri> GetCustomers()
        {
            return _dbContext.Musteri.ToList();
        }

        public void RemoveCustomer(Musteri musteri)
        {
            _dbContext.Remove(musteri);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Update(Musteri musteri)
        {
            _dbContext.Update(musteri);
            SaveChanges();
        }
    }
}
