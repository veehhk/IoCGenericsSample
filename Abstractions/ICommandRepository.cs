namespace DIApi
{
    using System.Threading.Tasks;

    public interface ICommandRepository<T> where T : class
    {
        void Add(T item);

        Task AddAsync(T item);
    }
}