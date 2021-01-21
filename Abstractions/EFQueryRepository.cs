namespace DIApi
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public class EFQueryRepository<T> : IQueryRepository<T> where T : class
    {
        private readonly DbContext _context;

        public EFQueryRepository(DbContext context) => _context = context;

        public IQueryable<T> Queryable => _context.QuerySet<T>();

        public bool Any() => Queryable.Any();

        public bool Any(Expression<Func<T, bool>> where) => Queryable.Any(where);
    }
}