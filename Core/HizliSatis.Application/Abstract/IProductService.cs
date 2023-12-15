using HizliSatis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.Abstractions
{
    public interface IProductService
    {
        List<Stok> GetProducts();
        void AddProduct(Stok stok);
        void Update(Stok stok);
        void RemoveProduct(Stok stok);
        Stok GetProductByFilter(Expression<Func<Stok,bool>>filter);
        Stok GetProductById(int id);
        void SaveChanges();
    }
}
