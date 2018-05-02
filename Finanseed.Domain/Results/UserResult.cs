using System;
using System.Collections.Generic;
using Finanseed.Domain.Base;
using Finanseed.Domain.Base.Interfaces;
using Finanseed.Domain.Entities;

namespace Finanseed.Domain.Results
{
    public class UserResult : Result, IResult
    {
        public UserResult(bool success, string message, Guid id, string name, 
        IList<Wallet> wallets)
        :base(success, message)
        {
            Id = id;
            Name = name;
            Wallets = wallets;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Wallet> Wallets { get; set; }
    }
}