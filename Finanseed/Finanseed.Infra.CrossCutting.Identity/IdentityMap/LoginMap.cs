using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration;

namespace Finanseed.Infra.CrossCutting.Identity.IdentityMap
{
    public class LoginMap : EntityTypeConfiguration<IdentityUserLogin>
    {
        public LoginMap()
        {
            ToTable("Logins");
            HasKey(x => x.UserId);
        }
    }
}
