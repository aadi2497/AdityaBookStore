using AdityaBooks.DataAccess.Repository.IRepository;
using AdityaBooks.Models;
using AdityaBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace AdityaBooks.DataAccess.Repository.IRepository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
