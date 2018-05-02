using Finanseed.Domain.Base;
using Flunt.Validations;

namespace Finanseed.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
            AddNotifications(new Contract()
            .Requires()
            
            );
        }

        public string Address { get; private set; }
        
    }
}