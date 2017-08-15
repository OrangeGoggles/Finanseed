using System;

namespace Finanseed.Domain.Entities
{
    public class CreditCard
    {
        public float Limit { get; set; }
        public float Balance { get; set; }
        public DateTime DueDate { get; set; }
    }
}