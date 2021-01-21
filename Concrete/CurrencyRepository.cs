namespace DIApi
{
    public class CurrencyRepository : EFRepository<CurrencyDomain>, ICurrencyRepository
    {
        public CurrencyRepository(TestDBContext context) : base(context) { }

    }
}