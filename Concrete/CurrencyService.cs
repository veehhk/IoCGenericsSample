namespace DIApi
{
    using System;
    using System.Threading.Tasks;

    public class CurrencyService : DomainService<Guid, CurrencyDomain>, ICurrencyService
    {
        public CurrencyService(IUnitOfWork unitOfWork, IRepository<CurrencyDomain> repository) : base(unitOfWork, repository)
        {
        }

        public override async Task<IResult<Guid>> AddAsync(CurrencyDomain domain)
        {
            await _repository.AddAsync(domain);
            await _unitOfWork.SaveChangesAsync();
            return Result<Guid>.Success(domain.Id);
        }
    }

}