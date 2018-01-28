using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FactorioLibrary.Model;

namespace FactorioLibrary.DataAccess
{
    public interface IDataContext
    {
        DbSet<User> Users { get; set; }
    }
}
