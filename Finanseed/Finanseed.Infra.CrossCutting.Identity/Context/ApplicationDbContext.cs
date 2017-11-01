using System.Data.Entity;
using Finanseed.Infra.CrossCutting.Identity.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Finanseed.Infra.CrossCutting.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("name=connFinanseed", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>()
                .ToTable("User")
                .Property(p => p.Id)
                .HasColumnName("ID");
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.Birthday);


        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
