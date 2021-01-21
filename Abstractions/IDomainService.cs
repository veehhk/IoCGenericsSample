namespace DIApi
{
    using System.Threading.Tasks;

    public interface IDomainService<TId, TDomain> where TDomain : Entity<TId>
    {
        Task<IResult<TId>> AddAsync(TDomain domain);
    }
}