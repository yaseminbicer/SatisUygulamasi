using HizliSatis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace HizliSatis.Application.Abstractions
{
    public interface IProductService
    {
        List<Stok> GetProducts();
        //void FindProduct(Stok product, int id=0);
        Stok GetStokById(int id);
        Stok GetStokByName(string ad);
        
        void AddProduct(Stok product);
        void RemoveProduct(Stok product);
        public Stok UpdateProduct(int id);
        int SaveChanges();
      
    }
}
