using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using AzadiSoft.UserManager.DataLayer;

namespace AzadiSoft.UserManager.ServiceLayer
{
    public interface IGenericService<TEntity> where TEntity: class
    {
        TEntity GetByID(object id);

        IQueryable<TEntity> GetAllQueryable(Expression<Func<TEntity, bool>> expression = null);

        void Insert(TEntity entity, bool saveChanges = true);

        void Delete(TEntity entity, bool saveChanges = true);

        void DeleteByID(object id);

        void Update(TEntity entity);

        IUnitOfWork UnitOfWork { get; }

        IDbSet<TEntity> DbSet { get; }
    }
}