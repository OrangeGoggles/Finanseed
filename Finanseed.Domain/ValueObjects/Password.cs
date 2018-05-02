using Finanseed.Domain.Base;
using Finanseed.Domain.Utils;
using Flunt.Validations;

namespace Finanseed.Domain.ValueObjects
{
    public class Password : Entity
    {
        public Password(string hash)
        {
            AddNotifications(new Contract()
            .Requires()
            .Matchs(hash, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$", "Password.Hash", 
            "A senha  precisa ter ao menos 8 caracteres, tendo ao menos uma letra minúscula, uma letra maiúscula e um número"));
            if(Valid){
                Hash = CriptographyUtil.CreateHash(hash);
            }
        }

        public string Hash { get; private set; }
        
        public bool IsValid(string obj){
            return CriptographyUtil.ValidatePassword(obj, Hash);
        }
    }
}