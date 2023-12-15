using HizliSatis.Application.Abstract;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.Concretes
{
    public class CustomerService :ICustomerService
    {
        private readonly AppDbContext _dbContext;
        public CustomerService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public CustomerService()
        {
        }
        public void AddCustomer(Musteri Customer)
        {
            _dbContext.Add(Customer);
        }
       
        public List<Musteri> GetCustomer()
        {
            return _dbContext.Musteri.ToList();
        }

        public void RemoveCustomer(Musteri Customer)
        {
            _dbContext.Remove(Customer);
            _dbContext.SaveChanges();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
