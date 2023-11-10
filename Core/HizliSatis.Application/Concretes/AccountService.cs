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
    public class AccountService : IAccountService
    {
        private readonly AppDbContext dbContext=new AppDbContext();

        public void AddUser(Kullanici user)
        {
            dbContext.Add(user);
        }

        public List<Kullanici> GetUsers()
        {
            return dbContext.Kullanici.ToList();
        }

        public void RemoveUser(Kullanici user)
        {
            dbContext.Remove(user);
            dbContext.SaveChanges();
        }

        public int SaveChanges()
        {
           return dbContext.SaveChanges();
        }
    }
}
