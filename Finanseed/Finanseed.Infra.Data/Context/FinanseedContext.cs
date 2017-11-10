using Finanseed.Domain.Entities;
using Finanseed.Infra.Data.EntityMap;
using Microsoft.EntityFrameworkCore;

namespace Finanseed.Infra.Data.Context
{
    public class FinanseedContext : DbContext
    {
        public FinanseedContext(DbContextOptions<FinanseedContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Wallet> Wallet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new WalletMap());
        }
    }
}
