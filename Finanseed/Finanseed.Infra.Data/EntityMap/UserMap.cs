using Finanseed.Domain.Entities;
using Finanseed.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finanseed.Infra.Data.EntityMap
{
    internal class UserMap : DbEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> obj)
        {
            obj.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();
            obj.Property(x => x.Birthday)
                .IsRequired();
            obj.Property(x => x.AccessFailedCount)
                .IsRequired();
            obj.Property(x => x.Email)
                .IsRequired();
            obj.Property(x => x.EmailConfirmed)
                .IsRequired();
            obj.Property(x => x.PasswordHash)
                .IsRequired();
            obj.Property(x => x.PhoneNumber)
                .IsRequired();
            obj.Property(x => x.PhoneNumberConfirmed)
                .IsRequired();
            obj.Property(x => x.UserName)
                .IsRequired();
        }
    }
}
