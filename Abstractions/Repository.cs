namespace DIApi
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly ICommandRepository<T> _commandRepository;
        private readonly IQueryRepository<T> _queryRepository;

        protected Repository(ICommandRepository<T> commandRepository, IQueryRepository<T> queryRepository)
        {
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
        }

        public IQueryable<T> Queryable => _queryRepository.Queryable;

        public void Add(T item) => _commandRepository.Add(item);

        public Task AddAsync(T item) => _commandRepository.AddAsync(item);

        public bool Any() => _queryRepository.Any();

        public bool Any(Expression<Func<T, bool>> where) => _queryRepository.Any(where);
    }

}