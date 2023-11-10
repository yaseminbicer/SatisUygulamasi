using HizliSatis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Application.Abstract
{
    public interface IAccountService
    {
        List<Kullanici> GetUsers();
        void AddUser(Kullanici user);
        void RemoveUser(Kullanici user);
        int SaveChanges();
    }
}
