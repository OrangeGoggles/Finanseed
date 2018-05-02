using Finanseed.Domain.Base;

namespace Finanseed.Domain.ValueObjects
{
    public class Balance : ValueObject
    {
        public Balance(decimal value)
        {
            Value = value;
        }

        public decimal Value { get; private set; }

        public void Sum(decimal value){
            Value += value;
        }

        public void Minus(decimal value){
            Value -= value;
        }
    }
}