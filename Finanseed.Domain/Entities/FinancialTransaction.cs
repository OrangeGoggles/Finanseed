using Finanseed.Domain.Base;
using Finanseed.Domain.Enums;
using Flunt.Validations;

namespace Finanseed.Domain.Entities
{
    public class FinancialTransaction : Entity
    {
        public FinancialTransaction(string name, decimal value, ETransactionRecursion recursion, TransactionCategory transactionCategory)
        {
            Name = name;
            Value = value;
            TransactionCategory = transactionCategory;
            Recursion = recursion;

            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(Name, 3, "FinancialTransaction.Name", "O nome de uma transação financeira precisa ter no mínimo 3 caracteres")
            .HasMaxLen(Name, 40, "FinancialTransaction.Name", "O nome de uma transação financeira precisa ter no máximo 40 caracteres")
            .IsGreaterThan(Value, 0, "FinancialTransaction.Value", "Uma transação financeira não pode ter valor nulo ou negativo")
            );
        }
        public string Name { get; private set; }
        public decimal Value { get; private set; }
        
        public ETransactionRecursion Recursion { get; private set; }

        public TransactionCategory TransactionCategory { get; private set; }
    }
}