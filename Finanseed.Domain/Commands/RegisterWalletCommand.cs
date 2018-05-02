using Finanseed.Domain.Base.Interfaces;
using Flunt.Notifications;
using Flunt.Validations;

namespace Finanseed.Domain.Commands
{
    public class RegisterWalletCommand : Notifiable, ICommand
    {
        public RegisterWalletCommand(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(Name, 3, "RegisterWalletCommand.Name", "O nome da cateira precisa ter no mínimo 3 caracteres")
            .HasMaxLen(Name, 40, "RegisterWalletCommand.Name", "O nome da carteira precisa ter no máximo 40 caracteres")
            );
        }
    }
}