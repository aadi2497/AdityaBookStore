using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace AdityaBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id); // Retrieve a category from database by its id
        // List of Categories based on requirements
        IEnumerable<T> GetAll(

            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null // Usefull for forgein key reference

            );

        void Add(T entity); //to add an entity

        void Remove(int id); // To remove and object
        void Remove(T entity); //To remove object using differnt way

        void RemoveRange(IEnumerable<T> entity); // remove a complete set using range of entity
    
    }
}
