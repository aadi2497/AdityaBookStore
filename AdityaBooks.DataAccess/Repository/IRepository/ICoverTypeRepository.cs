using AdityaBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType covertype);
    }
}
