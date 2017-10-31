using System.Data.Entity;

namespace Finanseed.Infra.Data.Context
{
    public class FinanseedContext : DbContext
    {
        public FinanseedContext() : base("")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
