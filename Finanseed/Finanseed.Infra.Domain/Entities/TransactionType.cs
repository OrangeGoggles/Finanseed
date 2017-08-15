using System;

namespace Finanseed.Domain.Entities
{
    public class TransactionType
    {
        public Guid ID { get; set; }
        public string TransactionTypeName { get; set; }
    }
}