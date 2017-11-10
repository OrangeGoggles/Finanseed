using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Finanseed.Infra.Data.Context
{
    public class FinanseedContextFactory : IDesignTimeDbContextFactory<FinanseedContext>
    {
        public FinanseedContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FinanseedContext>().UseSqlServer("connFinanseed");

            return new FinanseedContext(builder.Options);
        }
        public FinanseedContext CreateDbContext()
        {
            var builder = new DbContextOptionsBuilder<FinanseedContext>().UseSqlServer("connFinanseed");

            return new FinanseedContext(builder.Options);
        }
    }
}
