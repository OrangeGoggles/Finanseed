using Finanseed.Domain.Entities.Interfaces;
using System;

namespace Finanseed.Domain.Entities
{
    public class FinanceTransaction : IFinanceTransaction
    {
        public float Value { get; set; }
        public string Name { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}