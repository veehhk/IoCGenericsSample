namespace DIApi
{
    public interface IRepository<T> : ICommandRepository<T>, IQueryRepository<T> where T : class { }
}