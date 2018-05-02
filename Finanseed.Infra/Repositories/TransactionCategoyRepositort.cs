using System;
using Finanseed.Domain.Entities;
using Finanseed.Domain.Repositories;
using Finanseed.Infra.Context;

namespace Finanseed.Infra.Repositories
{
    public class TransactionCategoryRepository : Repository, ITransactionCategoryRepository
    {
        public TransactionCategoryRepository(FinanseedDataContext db) : base(db)
        {
        }

        public TransactionCategory GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
} 