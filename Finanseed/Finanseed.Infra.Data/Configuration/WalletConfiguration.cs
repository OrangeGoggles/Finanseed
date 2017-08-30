using Finanseed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finanseed.Infra.Data.Configuration
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasIndex(wallet => wallet.WalletID);
            builder.Property(wallet => wallet.WalletID).IsRequired().HasMaxLength(32);
            builder.Property(wallet => wallet.RealBalance).IsRequired();
            builder.Property(wallet => wallet.CurrentBalance).IsRequired();
        }
    }
}
