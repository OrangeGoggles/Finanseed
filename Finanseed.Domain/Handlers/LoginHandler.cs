using Finanseed.Domain.Base;
using Finanseed.Domain.Base.Interfaces;
using Finanseed.Domain.Commands;
using Finanseed.Domain.Results;

namespace Finanseed.Domain.Handlers
{
    public class LoginHandler : Handler<LoginCommand>
    {
        public override IResult Handle(LoginCommand obj)
        {
            throw new System.NotImplementedException();
        }
    }
}