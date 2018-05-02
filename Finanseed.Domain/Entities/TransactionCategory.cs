using Finanseed.Domain.Base;
using Finanseed.Domain.Enums;
using Flunt.Validations;

namespace Finanseed.Domain.Entities
{
    public class TransactionCategory : Entity
    {
        public TransactionCategory(string name, ETransactionType transactionType)
        {
            Name = name;
            TransactionType = transactionType;
            AddNotifications(new Contract()
            .Requires()
            .HasMaxLen(Name, 40, "TransactionCategory.Name", "O nome de uma categoria de transação deve ter no máximo 40 caracteres")
            .HasMinLen(Name, 3, "TransactionCategory.Name", "O nome de uma categoria de transação deve ter no mínimo 3 caracteres")
            );
        }

        public string Name { get; private set; }
        public ETransactionType TransactionType { get; private set; }
    }
}