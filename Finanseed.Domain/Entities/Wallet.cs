using System.Collections.Generic;
using Finanseed.Domain.Base;
using Finanseed.Domain.Enums;
using Finanseed.Domain.ValueObjects;
using Flunt.Validations;

namespace Finanseed.Domain.Entities
{
    public class Wallet : Entity
    {
        private List<FinancialTransaction> _transactions;
        public Wallet(string name)
        {
            Name = name;
            Balance = new Balance(0);
            _transactions = new List<FinancialTransaction>();
        }

        public string Name { get; private set; }
        public Balance Balance { get; private set; }
        //TODO: Credit Card
        //TODO: Bags
        //TODO: Banks
        public IReadOnlyCollection<FinancialTransaction> Transactions
        {
            get => _transactions;
        }

        public void AddTransaction(FinancialTransaction transaction){
            if(transaction.Valid)
            {
                if(transaction.TransactionCategory.TransactionType == ETransactionType.Out)
                    this.Balance.Minus(transaction.Value);

                if(transaction.TransactionCategory.TransactionType == ETransactionType.In)
                    this.Balance.Sum(transaction.Value);

                _transactions.Add(transaction);
            }
        }
    }
}