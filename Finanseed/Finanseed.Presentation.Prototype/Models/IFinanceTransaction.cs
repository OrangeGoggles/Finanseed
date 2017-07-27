using System;

namespace Finanseed.Presentation.Prototype.Models
{
    public interface IFinanceTransaction
    {
        float Value { get; set; }
        string Name { get; set; }
        TransactionType TransactionType { get; set; }
        DateTime TransactionDate { get; set; }
    }
}