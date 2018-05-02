using Finanseed.Domain.Base;
using Finanseed.Domain.Base.Interfaces;
using Finanseed.Domain.Commands;
using Finanseed.Domain.Entities;
using Finanseed.Domain.Enums;
using Finanseed.Domain.Repositories;

namespace Finanseed.Domain.Handlers
{
    public class FinancialTransactionHandler : Handler<RegisterFinancialTransactionCommand>
    {
        private readonly IWalletRepository _walletRepository;
        private readonly ITransactionCategoryRepository _financialCategoryRepository;

        public FinancialTransactionHandler(IWalletRepository walletRepository, ITransactionCategoryRepository financialCategoryRepository)
        {
            _walletRepository = walletRepository;
            _financialCategoryRepository = financialCategoryRepository;
        }

        public override IResult Handle(RegisterFinancialTransactionCommand obj)
        {
            //1. Fail Fast Validation
            obj.Validate();

            if (obj.Invalid)
                return new Result(false, "Não foi possível registrar transação financeira");

            //2. Buscar Entidades
            var wallet = _walletRepository.GetById(obj.WalletId);
            var financialCategory = _financialCategoryRepository.GetById(obj.TransactionCategoryId);

            //3. Montar Entidade
            var financialTransaction = new FinancialTransaction(obj.Name, obj.Value, obj.Recursion, financialCategory);

            //4. Relacionamentos
            wallet.AddTransaction(financialTransaction);

            //5. Validar Entidade
            if (wallet.Invalid)
                return new Result(false, "Não foi possível registrar transação financeira");

            //6. Persistir no Banco
            _walletRepository.Save(wallet);
            return new Result(true, "Transação Financeira inserida com sucesso");
        }

    }
}
