using HizliSatis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.Abstract
{
    public interface ICategoryService
    {
        List<Kategori> GetCategory();
        //void FindProduct(Stok product, int id=0);
        Kategori GetStokById(int id);
        Kategori GetStokByName(string ad);

        void AddCategory(Kategori kategori);
        void RemoveCategory(Kategori kategori);
        public Kategori UpdateCategory(int id);
        int SaveChanges();
    }
}
