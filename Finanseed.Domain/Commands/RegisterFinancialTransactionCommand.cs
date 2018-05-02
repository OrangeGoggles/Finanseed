using System;
using Finanseed.Domain.Base.Interfaces;
using Finanseed.Domain.Enums;
using Flunt.Notifications;

namespace Finanseed.Domain.Commands
{
    public class RegisterFinancialTransactionCommand : Notifiable, ICommand
    {
        public Guid WalletId { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public ETransactionRecursion Recursion { get; set; }
        public Guid TransactionCategoryId { get; set; }
        public void Validate()
        {
            
        }
    }
}