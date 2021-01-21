namespace DIApi
{
    using System;

    public class CurrencyDomain : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }

        #nullable enable
        public string? Symbol { get; set; }
        #nullable disable

        #region Behaviors

        public void Activate() => Status = true;
        public void DeActivate() => Status = false;
        public void UpdateName(string name) => Name = name;
        public void UpdateSymbol(string symbol) => Symbol = symbol;

        #endregion
    }
}