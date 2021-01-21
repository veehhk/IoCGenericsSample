namespace DIApi
{
    using System.Threading.Tasks;

    public abstract class DomainService<TId, TDomain> : IDomainService<TId, TDomain> where TDomain : Entity<TId>
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IRepository<TDomain> _repository;

        public DomainService(IUnitOfWork unitOfWork, IRepository<TDomain> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public abstract Task<IResult<TId>> AddAsync(TDomain domain);
    }
}