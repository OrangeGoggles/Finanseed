using System.Collections.Generic;
using System.Linq;
using Finanseed.Domain.Base;
using Finanseed.Domain.Base.Interfaces;
using Finanseed.Domain.Commands;
using Finanseed.Domain.Entities;
using Finanseed.Domain.Repositories;
using Finanseed.Domain.Results;
using Finanseed.Domain.Services;
using Finanseed.Domain.ValueObjects;

namespace Finanseed.Domain.Handlers
{
    public class UserHandler : Handler<RegisterUserCommand>
    {
        private readonly IUserRepository _repository;
        private readonly IEmailService _emailService;

        public UserHandler(IUserRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public override IResult Handle(RegisterUserCommand obj)
        {
            //1. Fail Fast Validation
            obj.Validate();
            
            if (obj.Invalid)
                return new Result(false,"Não foi possível cadastrar novo Usuário" );

            //2. Verificar Dados existentes na base de Dados
            if(_repository.EmailExists(obj.Address))
                return new Result(false, "E-mail já utilizado");
            
            //3. Montar ValueObjects
            var name = new Name(obj.FirstName, obj.LastName);
            var email = new Email(obj.Address);
            var pwd = new Password(obj.Pwd);

            //4. Montar Entities
            var user = new User(name, email, pwd);
            List<Wallet> wallets = TransformWalletsList(obj);

            //5. Montar Relacionamentos
            user.AddWallets(wallets);

            //6. Agregar Notifications
            AddNotifications(user);

            //7. Persistir Dados
            if(Invalid)
                return new Result(false, "Não foi possível cadastrar novo Usuário");
            
            user = _repository.Save(user);
            
            //8. Enviar E-mail
            _emailService.Send(user.Email.ToString(), "Bem vindo ao Finanseed", "Seja bem vindo ao Finansed");

            //9. Retornar dados (Id, Name e Wallets)
            return new UserResult(true, "Usuário Cadastrado com sucesso", user.Id, user.Name.ToString(), user.Wallets.ToList());
        }

        private List<Wallet> TransformWalletsList(RegisterUserCommand obj)
        {
            List<Wallet> wallets = new List<Wallet>();
            foreach (var walletCommand in obj.Wallet)
            {
                var wallet = new Wallet(walletCommand.Name);
                if (wallet.Valid)
                    wallets.Add(wallet);
            }
            return wallets;
        }
    }
}