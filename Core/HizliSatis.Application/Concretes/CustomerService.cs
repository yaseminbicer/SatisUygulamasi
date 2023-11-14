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
        private readonly AppDbContext dbContext = new AppDbContext();

        public void AddCustomer(Musteri Customer)
        {
            dbContext.Add(Customer);
        }
       
        public List<Musteri> GetCustomer()
        {
            return dbContext.Musteri.ToList();
        }

        public void RemoveCustomer(Musteri Customer)
        {
            dbContext.Remove(Customer);
            dbContext.SaveChanges();
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }
    }
}
