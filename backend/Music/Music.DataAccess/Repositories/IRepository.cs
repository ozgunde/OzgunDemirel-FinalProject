using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Music.Models;

namespace Music.DataAccess.Repositories
{
    public interface IRepository<TEntity> where TEntity : IEntity, new()
    {
        IList<TEntity> GetAll();
        TEntity GetByID(int id);
        IList<TEntity> GetWithCriteria(Expression<Func<TEntity, bool>> criteria);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity genre);
        void Delete(int id);
        void Delete(TEntity entity);
    }
}
