using System;
using System.Collections.Generic;
using System.Text;
using FactorioLibrary.Repository;

namespace FactorioLibrary.Model
{
    public class User : IModel<User>
    {
        private readonly IUserRepository _repository;

        public User(IUserRepository repo)
        {
            _repository = repo;
        }

        int Id { get; set; }
        int IModel<User>.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime IModel<User>.CreatedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ModifiedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ModifiedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
