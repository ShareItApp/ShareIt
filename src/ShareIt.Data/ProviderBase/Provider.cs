using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ShareIt.Data.ProviderBase
{
    public abstract class Provider<T> : IProvider<T>
        where T : class
    {
        public Provider(ApplicationDbContext context)
        {
            this.Context = context;
            this.Set = this.Context.Set<T>();
        }

        public ApplicationDbContext Context { get; }

        public DbSet<T> Set { get; }

        public IEnumerable<T> GetAll() => this.Set;

        public IEnumerable<T> GetBy(Expression<Func<T, bool>> expression) => this.Set.Where(expression);

        public void Create(T entity) => this.Set.Add(entity);

        public void Update(T entity) => this.Set.Update(entity);

        public void Delete(T entity) => this.Set.Remove(entity);
    }
}
