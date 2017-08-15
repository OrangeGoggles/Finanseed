using System;

namespace Finanseed.Domain.Entities.Interfaces
{
    public interface IFinanceTransaction
    {
        float Value { get; set; }
        string Name { get; set; }
        TransactionType TransactionType { get; set; }
        DateTime TransactionDate { get; set; }
    }
}