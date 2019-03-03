using System.Data.Entity;
using AzadiSoft.UserManager.DomainModels;

namespace AzadiSoft.UserManager.DataLayer
{
    public partial class MainContext : DbContext , IUnitOfWork
    {
        public MainContext()
            : base("name=MainContext")
        {
        }

        public virtual IDbSet<EducationLevel> EducationLevels { get; set; }

        public virtual IDbSet<Role> Roles { get; set; }

        public virtual IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EducationLevel>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.EducationLevel)
                .HasForeignKey(e => e.EducationLevel_ID);
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
