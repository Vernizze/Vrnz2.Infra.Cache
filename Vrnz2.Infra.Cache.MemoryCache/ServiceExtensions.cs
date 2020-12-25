using Microsoft.Extensions.DependencyInjection;
using Vrnz2.Infra.Cache.Interfaces;

namespace Vrnz2.Infra.Cache.MemoryCache
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddCache(this IServiceCollection services) 
            => services
                .AddMemoryCache()
                .AddTransient<ICache, Cache>();
    }
}
