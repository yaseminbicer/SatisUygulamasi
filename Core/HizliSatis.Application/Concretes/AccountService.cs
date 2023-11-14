using HizliSatis.Application.Abstract;
using HizliSatis.Domain.Entities;
using HizliSatis.Persistence.Context;
using Microsoft.EntityFrameworkCore;
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
            dbContext.Kullanici.Add(user);
            SaveChanges();
            /* if (user != null && user.Id > 0)
             {
                 dbContext.Kullanici.Add(user);
                 SaveChanges();
             }*/
        }

        public List<Kullanici> GetUsers()
        {
            return dbContext.Kullanici.ToList();
        }

        public void RemoveUser(Kullanici user)
        {
            if (user != null && user.Id > 0)
            {
                dbContext.Kullanici.Remove(user);
                dbContext.SaveChanges();
            }
           
        }
        public bool AuthenticateUser(string kullaniciAdi, string sifre)
        {
            var kullanici = dbContext.Kullanici.FirstOrDefault(s => s.KullaniciAdi == kullaniciAdi && s.Sifre == sifre);
            return kullanici != null;
        }

        public int SaveChanges()
        {
           return dbContext.SaveChanges();
        }
    }
}
