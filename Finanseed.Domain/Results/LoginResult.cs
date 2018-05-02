using Finanseed.Domain.Base;
using Finanseed.Domain.Base.Interfaces;
using Finanseed.Domain.Entities;

namespace Finanseed.Domain.Results
{
    public class LoginResult : Result, IResult
    {
        public LoginResult(bool success, string message) : base(success, message)
        {
        }

        public User User { get; set; } 
    }
}