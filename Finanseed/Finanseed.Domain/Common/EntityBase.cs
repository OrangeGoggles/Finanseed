using FluentValidator;
using System;

namespace Finanseed.Domain.Common
{
    public abstract class EntityBase : Notifiable
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
            CreationDate = new DateTime();
        }
        public Guid Id { get; private set; }
        public DateTime CreationDate { get; set; }
    }
}
