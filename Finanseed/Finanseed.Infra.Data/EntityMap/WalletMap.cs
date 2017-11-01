using Finanseed.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Finanseed.Infra.Data.EntityMap
{
    public class WalletMap : EntityTypeConfiguration<Wallet>
    {
        public WalletMap()
        {
            Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name)
                .IsRequired();

            Property(x => x.Balance)
                .IsRequired();

            Property(x => x.CreationDate)
                .IsRequired();

            HasRequired(x => x.Owner)
                .WithMany(x => x.Wallets).
                HasForeignKey(x => x.OwnerID);
        }
    }
}
