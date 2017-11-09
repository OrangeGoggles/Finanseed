using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration;

namespace Finanseed.Infra.CrossCutting.Identity.IdentityMap
{
    public class ClaimsMap : EntityTypeConfiguration<IdentityUserClaim>
    {
        public ClaimsMap()
        {
            ToTable("Claims");
        }
    }
}
