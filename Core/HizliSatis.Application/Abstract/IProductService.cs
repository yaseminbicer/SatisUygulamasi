using HizliSatis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.Abstractions
{
    public interface IProductService
    {
        List<Stok> GetProducts();
    }
}
