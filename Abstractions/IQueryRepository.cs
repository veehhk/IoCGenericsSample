namespace DIApi
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IQueryRepository<T> where T : class
    {
        IQueryable<T> Queryable { get; }

        bool Any();

        bool Any(Expression<Func<T, bool>> where);
    }
}