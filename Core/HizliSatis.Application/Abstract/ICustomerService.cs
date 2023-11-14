using HizliSatis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.Abstract
{
    public interface ICustomerService
    {
        List<Musteri> GetCustomer();
        void AddCustomer(Musteri Customer);
        void RemoveCustomer(Musteri Customer);
        int SaveChanges();
    }
}
