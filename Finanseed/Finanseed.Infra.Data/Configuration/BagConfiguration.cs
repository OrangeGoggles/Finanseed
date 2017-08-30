using Finanseed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finanseed.Infra.Data.Configuration
{
    class BagConfiguration : IEntityTypeConfiguration<Bag>
    {
        public void Configure(EntityTypeBuilder<Bag> builder)
        {
            builder
                .HasOne(bag => bag.Wallet)
                .WithMany(wallet => wallet.Bags)
                .HasForeignKey(bag => bag.WalletID);
            builder
                .Property(bag => bag.Balance).IsRequired();
            builder
                .Property(bag => bag.Limit).IsRequired();
            builder
                .HasIndex(bag => bag.BagID);
        }
    }
}
