using System;
using System.Collections.Generic;
using System.Text;
using FactorioLibrary.Model;
using FactorioLibrary.DataAccess;

namespace FactorioLibrary.Repository
{
    public class UserRepository : IUserRepository
    {
        private IDataContext _dataContext;

        public UserRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
