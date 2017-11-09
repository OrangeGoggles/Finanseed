using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration;

namespace Finanseed.Infra.CrossCutting.Identity.IdentityMap
{
    public class IdentityUserMap : EntityTypeConfiguration<IdentityUser>
    {
        public IdentityUserMap()
        {
            ToTable("Users");
            Property(p => p.Id)
            .HasColumnName("ID");
        }
    }
}
