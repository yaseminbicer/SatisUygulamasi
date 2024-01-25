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
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _dbContext;
        public CategoryService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CategoryService()
        {
        }

        public List<Kategori> GetCategory()
        {
            return _dbContext.Kategori.ToList();
        }
        public void AddCategory(Kategori kategori)
        {
            _dbContext.Add(kategori);
            SaveChanges();
        }
        public void RemoveCategory(Kategori kategori)
        {
            _dbContext.Remove(kategori);
            SaveChanges();

        }
        public Kategori UpdateCategory(int id)
        {
            var guncellenecekKategori = _dbContext.Kategori.Find(id);

            if (guncellenecekKategori != null)
            {
                SaveChanges();
            }

            return guncellenecekKategori;

        }
        public Kategori GetStokById(int id)
        {
            var kategori = _dbContext.Kategori.FirstOrDefault(p => p.Id == id);
            return kategori;
        }
        public Kategori GetStokByName(string ad)
        {
            return _dbContext.Kategori.FirstOrDefault(Kategori => Kategori.KategoriAdi == ad);
        }
        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
