using Finanseed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finanseed.Infra.Mappings
{
    public class FinancialTransactionMap : IEntityTypeConfiguration<FinancialTransaction>
    {
        public void Configure(EntityTypeBuilder<FinancialTransaction> builder)
        {
            builder.ToTable("FinancialTransaction");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Recursion).IsRequired();
            builder.HasOne(x => x.TransactionCategory);
        }
    }
}