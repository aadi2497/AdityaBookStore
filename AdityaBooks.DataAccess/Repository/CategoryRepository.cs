using AdityaBooks.DataAccess.Repository.IRepository;
using AdityaBooks.Models;
using AdityaBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
        
        
        // Publiv void Updated after new class created in ICategoryRepository.cs File using Poteinal fix.

        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(c => c.Id == category.Id);
            if(objFromDb != null) //save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
