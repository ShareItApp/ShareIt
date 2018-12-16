using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShareIt.Core.Data;

namespace ShareIt.Core
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureCoreServices(this IServiceCollection @this, string connectionString)
        {
            @this.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(connectionString));

            return @this;
        }
    }
}
