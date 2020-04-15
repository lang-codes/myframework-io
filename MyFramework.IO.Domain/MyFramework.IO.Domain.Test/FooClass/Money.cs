using System;
using System.Collections.Generic;

namespace MyFramework.IO.Domain.Test.FooClass
{
    public class Money : ValueObject
    {
        public string Currency { get; }
        public decimal Amount { get; }

        public Money(string currency, decimal amount)
        {
            Currency = currency;
            Amount = amount;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Currency.ToUpper();
            yield return Math.Round(Amount, 2);
        }

        //Example 1: var money1 = new Money("usd", 2.2222m);
        //Example 2: var money2 = new Money("USD", 2.22m);
    }
}
