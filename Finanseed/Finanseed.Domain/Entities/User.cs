using Finanseed.Domain.ValueObject;
using System;

namespace Finanseed.Domain.Entities
{
    public class User : EntityBase
    {
        public Guid ID { get; set; }
        public Name Name { get; set; }
        public Email Email { get; set; }
        public Phone Phone { get; set; }
        public DateTime Birthday { get; set; }
    }
}
