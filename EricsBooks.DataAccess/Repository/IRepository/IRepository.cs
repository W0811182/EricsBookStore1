using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace EricsBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {

        T Get(int id);   //retrieve category from DB based on id
        //list of categories based on requirements
        IEnumerable<T> GetAll (
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        string includeProperties = null      //useful for foregin eky references
           );
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity);   //add an entity

        void Remove(int id);  //remove object or category

        void Remove(T entity); //anoth way to remove object

        void RemoveRange(IEnumerable<T> entity);   //removes complete range of entities
    }
}
