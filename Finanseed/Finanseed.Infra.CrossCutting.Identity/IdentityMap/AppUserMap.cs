using Finanseed.Infra.CrossCutting.Identity.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Finanseed.Infra.CrossCutting.Identity.IdentityMap
{
    public class AppUserMap : EntityTypeConfiguration<ApplicationUser>
    {
        public AppUserMap()
        {
            ToTable("Users");
            Property(p => p.Id)
                .HasColumnName("ID");

        }
    }
}
