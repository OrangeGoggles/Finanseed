using Finanseed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finanseed.Infra.Mappings
{
    public class TransactionCategoryMap : IEntityTypeConfiguration<TransactionCategory>
    {
        public void Configure(EntityTypeBuilder<TransactionCategory> builder)
        {
            builder.ToTable("TransactionCategory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TransactionType);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.HasAlternateKey(x => x.Name);
        }
    }
}