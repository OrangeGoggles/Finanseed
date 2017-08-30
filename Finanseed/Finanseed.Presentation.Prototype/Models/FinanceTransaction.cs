﻿using System;

namespace Finanseed.Presentation.Prototype.Models
{
    public class FinanceTransaction : IFinanceTransaction
    {
        public float Value { get; set; }
        public string Name { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}