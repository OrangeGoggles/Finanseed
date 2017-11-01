namespace Finanseed.Domain.ValueObject
{
    public class Phone
    {
        public string PhoneNumber { get; set; }
        public EnumPhoneType PhoneType { get; set; }
        public enum EnumPhoneType
        {
            Cellphone = 1,
            Home = 2,
            Work = 3
        }
    }
}
