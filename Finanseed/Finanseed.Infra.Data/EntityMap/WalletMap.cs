using Finanseed.Domain.Entities;
using Finanseed.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finanseed.Infra.Data.EntityMap
{
    internal class WalletMap : DbEntityConfiguration<Wallet>
    {
        public WalletMap()
        {
           
        }

        public override void Configure(EntityTypeBuilder<Wallet> obj)
        {
            obj.Property(x => x.ID)
               .ValueGeneratedOnAdd()
               .IsRequired();

            obj.Property(x => x.Name)
                .IsRequired();

            obj.Property(x => x.Balance)
                .IsRequired();

            obj.Property(x => x.CreationDate)
                .IsRequired();

            obj.HasOne(x => x.Owner)
                .WithMany(x => x.Wallets).
                HasForeignKey(x => x.OwnerID);
        }
    }
}
