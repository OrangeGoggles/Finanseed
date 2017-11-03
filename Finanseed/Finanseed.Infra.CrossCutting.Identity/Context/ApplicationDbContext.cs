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
                .Property(x => x.Birthday)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.AccessFailedCount)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.Email)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.EmailConfirmed)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.LockoutEnabled)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.LockoutEndDateUtc)
                .IsOptional();
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.PasswordHash)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.PhoneNumber)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.PhoneNumberConfirmed)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.SecurityStamp)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.TwoFactorEnabled)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .Property(x => x.UserName)
                .IsRequired();


        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
