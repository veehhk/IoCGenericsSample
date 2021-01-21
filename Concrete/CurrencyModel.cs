namespace DIApi
{
    using System;

    public class CurrencyModel : Entity<Guid>
    {
        public string Code { get; init; }
        public string Name { get; init; }

        #nullable enable
        public string? Symbol { get; init; }
        #nullable disable
    }
}