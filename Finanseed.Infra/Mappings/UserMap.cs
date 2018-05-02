using Finanseed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finanseed.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Name.FirstName)
                .IsRequired()
                .HasMaxLength(60);
            
            builder.Property(x => x.Name.LastName)
                .IsRequired()
                .HasMaxLength(60);
            
            builder.Property(x => x.Email.Address)
                .IsRequired()
                .HasMaxLength(160);
            
            builder.HasAlternateKey(x => x.Email.Address);

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(32);
            
            builder.Property(x => x.Active).IsRequired();
            
            builder.HasMany(x => x.Wallets);
        }
    }
}