using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace AzadiSoft.UserManager.DataLayer
{
    public interface IUnitOfWork
    {
        int SaveChanges();

        Database Database { get; }

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T t) where T : class;
    }
}