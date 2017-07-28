using Finanseed.Presentation.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Finanseed.Presentation.Prototype.DAL.Context
{
    public class FinanSeedContext : DbContext
    {
        public FinanSeedContext() : base("name=FinanseedDB")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<FinanceTransaction> FinanceTransaction { get; set; }
        public DbSet<Bag> Bag { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
        }
    }
}