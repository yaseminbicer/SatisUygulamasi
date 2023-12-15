using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAllList();
        T Get(int id);
        T GetByFilter(Expression<Func<T, bool>> filter);
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);
    }
}
