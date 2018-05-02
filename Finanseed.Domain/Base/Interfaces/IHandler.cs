namespace Finanseed.Domain.Base.Interfaces
{
    public interface IHandler<T> where T : ICommand
    {
        IResult Handle(T obj);
    }
}