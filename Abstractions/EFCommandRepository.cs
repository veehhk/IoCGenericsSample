namespace DIApi
{
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class EFCommandRepository<T> : ICommandRepository<T> where T : class
    {
        private readonly DbContext _context;

        public EFCommandRepository(DbContext context) => _context = context;

        private DbSet<T> Set => _context.CommandSet<T>();

        public void Add(T item) => Set.Add(item);

        public Task AddAsync(T item) => Set.AddAsync(item).AsTask();
    }
}