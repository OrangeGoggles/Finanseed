using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration;

namespace Finanseed.Infra.CrossCutting.Identity.IdentityMap
{
    public class RoleMap : EntityTypeConfiguration<IdentityRole>
    {
        public RoleMap()
        {
            ToTable("Roles");
        }
    }
}
