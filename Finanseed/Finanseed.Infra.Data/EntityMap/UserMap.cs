using Finanseed.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Finanseed.Infra.Data.EntityMap
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(x => x.Birthday)
                .IsRequired();
            Property(x => x.AccessFailedCount)
                .IsRequired();
            Property(x => x.Email)
                .IsRequired();
            Property(x => x.EmailConfirmed)
                .IsRequired();
            Property(x => x.LockoutEnabled)
                .IsRequired();
            Property(x => x.LockoutEndDateUtc)
                .IsOptional();
            Property(x => x.PasswordHash)
                .IsRequired();
            Property(x => x.PhoneNumber)
                .IsRequired();
            Property(x => x.PhoneNumberConfirmed)
                .IsRequired();
            Property(x => x.SecurityStamp)
                .IsRequired();
            Property(x => x.TwoFactorEnabled)
                .IsRequired();
            Property(x => x.UserName)
                .IsRequired();
    }
    }
}
