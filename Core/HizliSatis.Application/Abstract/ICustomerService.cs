using HizliSatis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.Abstract
{
    public interface ICustomerService
    {
        List<Musteri> GetCustomers();
        void AddCustomer(Musteri musteri);
        void Update(Musteri musteri);
        void RemoveCustomer(Musteri musteri);
        Musteri GetCustomerByFilter(Expression<Func<Musteri, bool>> filter);
        Musteri GetCustomerById(int id);
        void SaveChanges();
    }
}
