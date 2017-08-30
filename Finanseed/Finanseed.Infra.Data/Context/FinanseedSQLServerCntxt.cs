using Finanseed.Domain.Entities;
using Finanseed.Presentation.Prototype.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Finanseed.Infra.Data.Context
{
    public class FinanseedSQLServerCntxt : DbContext
    {
        public FinanseedSQLServerCntxt(DbContextOptions<FinanseedSQLServerCntxt> options):base(options)
        {

        }
        public DbSet<Bag> Bag { get; set; }
        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<FinanceTransaction> FinanceTransaction { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
