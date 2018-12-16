using Microsoft.Extensions.DependencyInjection;

namespace ShareIt.Core
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureCoreServices(this IServiceCollection @this)
        {
            return @this;
        }
    }
}
