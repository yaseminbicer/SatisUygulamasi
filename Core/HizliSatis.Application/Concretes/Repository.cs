using HizliSatis.Application.Abstract;
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
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().AddAsync(entity);
            _context.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChangesAsync();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetAllList()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public T GetByFilter(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().AsNoTracking().FirstOrDefault(filter);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
