using Finanseed.Domain.Base.Interfaces;
using Flunt.Notifications;

namespace Finanseed.Domain.Base
{
    public abstract class Handler<T> : Notifiable, IHandler<T> where T : ICommand
    {
        public abstract IResult Handle(T obj);
    }
}