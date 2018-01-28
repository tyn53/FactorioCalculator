using System;
using System.Collections.Generic;
using System.Text;
using FactorioLibrary.Repository;
using Microsoft.EntityFrameworkCore;

namespace FactorioLibrary.Model
{
    public class User : IModel<User>
    {
        private readonly IUserRepository _repository;

        public User(IUserRepository repo)
        {
            _repository = repo;
        }

        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }

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
