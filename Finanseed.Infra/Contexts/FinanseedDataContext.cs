using Finanseed.Domain.Entities;
using Finanseed.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Finanseed.Infra.Context
{
    public class FinanseedDataContext : DbContext
    {
        public FinanseedDataContext(DbContextOptions<FinanseedDataContext> options):base(options)
        {
            
        }
        public DbSet<User> Users {get; set;}
        public DbSet<Wallet> Wallets {get; set;}
        public DbSet<TransactionCategory> TransactionCategories { get; set; }
        public DbSet<FinancialTransaction> FinancialTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new WalletMap());
            modelBuilder.ApplyConfiguration(new FinancialTransactionMap());
            modelBuilder.ApplyConfiguration(new TransactionCategoryMap());
        }
    } 
}