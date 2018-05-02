using System;
using Finanseed.Domain.Entities;

namespace Finanseed.Domain.Repositories
{
    public interface ITransactionCategoryRepository
    {
        TransactionCategory GetById(Guid id);
    }
}