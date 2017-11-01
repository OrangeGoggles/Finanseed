using Finanseed.Domain.Entities;
using Finanseed.Infra.Data.EntityMap;
using System.Data.Entity;

namespace Finanseed.Infra.Data.Context
{
    public class FinanseedContext : DbContext
    {
        public FinanseedContext() : base("Name=connFinanseed")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<User> User { get; set; }
        public DbSet<Wallet> Wallet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new WalletMap());
        }
    }
}
