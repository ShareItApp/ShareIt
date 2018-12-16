using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ShareIt.Data.ProviderBase
{
    public interface IProvider<T>
        where T : class
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> GetBy(Expression<Func<T, bool>> expression);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
