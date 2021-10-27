using System;
using JustCSharp.ShopeeOpenSDK;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddShopeeSDK(this IServiceCollection services)
        {
            services.AddHttpClient(nameof(ShopeeClient));

            services.AddSingleton<IShopeeClient, ShopeeClient>();
            services.AddSingleton<IShopeeKeyManager, ShopeeKeyManager>();

            return services;
        }
        
        public static IServiceCollection AddShopeeSDK(this IServiceCollection services, Action<ShopeeOptions> setupAction)
        {
            services.Configure(setupAction);
            return services.AddShopeeSDK();
        }
    }
}
