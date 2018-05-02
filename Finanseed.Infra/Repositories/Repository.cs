using Finanseed.Infra.Context;

namespace Finanseed.Infra.Repositories
{
    public abstract class Repository
    {
        internal readonly FinanseedDataContext db;

        public Repository(FinanseedDataContext db)
        {
            this.db = db;
        }
    }
}