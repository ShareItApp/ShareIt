using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ShareIt.Core
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDbContext<TContext>(this IServiceCollection @this, string connectionString)
            where TContext : DbContext
        {
            @this.AddDbContext<TContext>(o => o.UseSqlServer(connectionString));

            return @this;
        }

        public static IServiceCollection AddCoreServices(this IServiceCollection @this)
        {
            return @this;
        }
    }
}
