using Finanseed.Domain.Common;
using System;

namespace Finanseed.Domain.Entities
{
    public class Spent : EntityBase
    {
        public Guid ID { get; set; }
        public int SpentTypeID { get; set; }
        public virtual SpentType SpentType { get; set; }
    }
}