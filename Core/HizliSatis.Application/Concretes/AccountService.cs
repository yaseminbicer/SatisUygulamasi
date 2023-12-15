using HizliSatis.Application.Abstract;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.Concretes
{
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _dbContext = new AppDbContext();

        public AccountService()
        {
        }

        public AccountService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddUser(Kullanici user)
        {
            _dbContext.Add(user);
            SaveChanges();
        }

        public Kullanici GetUserByFilter(Expression<Func<Kullanici, bool>> filter)
        {
            return _dbContext.Kullanici.FirstOrDefault(filter);
        }

        public Kullanici GetUserById(int id)
        {
            return _dbContext.Kullanici.Find(id);
        }

        public List<Kullanici> GetUsers()
        {
            return _dbContext.Kullanici.ToList();
        }

        public void RemoveUser(Kullanici user)
        {
            _dbContext.Remove(user);
            _dbContext.SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Update(Kullanici user)
        {
            _dbContext.Update(user);
            SaveChanges();
        }
    }
}
