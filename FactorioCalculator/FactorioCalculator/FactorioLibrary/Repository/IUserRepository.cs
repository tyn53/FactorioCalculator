using System;
using System.Collections.Generic;
using System.Text;
using FactorioLibrary.Model;

namespace FactorioLibrary.Repository
{
    public interface IUserRepository
    {
        User GetUser(int id);
        IEnumerable<User> GetUsers();
        bool UpdateUser(User user);
        bool DeleteUser(int id);
        bool DeleteUser(User user);

    }
}
