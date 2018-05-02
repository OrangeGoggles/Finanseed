using Finanseed.Domain.Base.Interfaces;

namespace Finanseed.Domain.Base
{
    public class Result : IResult
    {
        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
    }
}