using System;
using System.Linq;
using System.Linq.Expressions;

namespace FBC.Northwind.RepositoryInterfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //RETRIEVE METHODS
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        IQueryable<TEntity> Get();
        //MODIFICATION METHODS
        void Add(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        void Update(TEntity entityToUpdate);
    }
}