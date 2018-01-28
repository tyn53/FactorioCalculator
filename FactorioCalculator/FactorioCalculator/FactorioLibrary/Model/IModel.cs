using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FactorioLibrary.Model
{
    public interface IModel<T> where T : IModel<T> 
    {
        int Id { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
        int CreatedBy { get; set; }
        int ModifiedBy { get; set; }

        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
