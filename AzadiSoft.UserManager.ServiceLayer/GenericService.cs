using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AzadiSoft.UserManager.DataLayer;

namespace AzadiSoft.UserManager.ServiceLayer
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenericService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            UnitOfWork = unitOfWork;
            DbSet = unitOfWork.Set<TEntity>();
        }

        public TEntity GetByID(object id)
        {
            var entity = DbSet.Find(id);

            return entity;
        }

        public IQueryable<TEntity> GetAllQueryable(Expression<Func<TEntity, bool>> expression = null)
        {
            var query = DbSet.AsQueryable();

            if (expression != null)
            {
                query = query.Where(expression);
            }

            return query;
        }

        public void Insert(TEntity entity, bool saveChanges = true)
        {
            DbSet.Add(entity);

            if (saveChanges)
            {
                _unitOfWork.SaveChanges();
            }
        }

        public void Delete(TEntity entity, bool saveChanges = true)
        {            
            DbSet.Remove(entity);

            if (saveChanges)
            {
                _unitOfWork.SaveChanges();
            }

        }

        public void DeleteByID(object id)
        {
            var entity = GetByID(id);

            if (entity != null)
            {
                Delete(entity);
            }
        }

        public void Update(TEntity entity)
        {
            var entry = UnitOfWork.Entry<TEntity>(entity);

            entry.State = EntityState.Modified;

            UnitOfWork.SaveChanges();
        }

        public IUnitOfWork UnitOfWork { get; }

        public IDbSet<TEntity> DbSet { get; }
    }
}
