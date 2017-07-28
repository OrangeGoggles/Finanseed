using System;

namespace Finanseed.Presentation.Prototype.Models
{
    public class FinanceTransaction : IFinanceTransaction
    {
        public float Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TransactionType TransactionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime TransactionDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}