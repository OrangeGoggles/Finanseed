using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration;

namespace Finanseed.Infra.CrossCutting.Identity.IdentityMap
{
    public class UserRoleMap : EntityTypeConfiguration<IdentityUserRole>
    {
        public UserRoleMap()
        {
            ToTable("UserRole");
            HasKey(x => x.RoleId);
        }
    }
}
