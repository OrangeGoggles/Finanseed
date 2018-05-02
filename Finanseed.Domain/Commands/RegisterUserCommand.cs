using System.Collections.Generic;
using Finanseed.Domain.Base.Interfaces;
using Flunt.Notifications;
using Flunt.Validations;

namespace Finanseed.Domain.Commands
{
    public class RegisterUserCommand : Notifiable, ICommand
    {
        
        public RegisterUserCommand(string firstName, string lastName, string address, string pwd)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Pwd = pwd;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Pwd { get; set; }
        public List<RegisterWalletCommand> Wallet{get; set;}

        public void Validate()
        {
            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(FirstName, 3, "Name.FirstName", "O nome precisa ter no mínimo 3 caracteres")
            .HasMaxLen(FirstName, 40, "Name.FirstName", "O nome precisa ter no máximo 40 caracteres")
            .HasMinLen(LastName, 3, "Name.LastName", "O sobrenome precisa ter no mínimo 3 caracteres")
            .HasMaxLen(LastName, 40, "Name.LastName", "O sobrenome precisa ter no máximo 40 caracteres")
            .IsEmail(Address, "Email.Address", "E-mail inválido")
            .Matchs(Pwd, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$", "Password.Hash", 
            "A senha  precisa ter ao menos 8 caracteres, tendo ao menos uma letra minúscula, uma letra maiúscula e um número")
            );
        }
    }
}