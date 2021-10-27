using System.Threading.Tasks;
using System.Net.Http;
using JustCSharp.ShopeeOpenSDK.Request;
using JustCSharp.ShopeeOpenSDK.Response;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JustCSharp.ShopeeOpenSDK
{
    public class ShopeeClient: IShopeeClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger _logger;
        private readonly ShopeeOptions _shopeeOptions;

        public ShopeeClient(IHttpClientFactory httpClientFactory, ILogger<ShopeeClient> logger, IOptions<ShopeeOptions> shopeeOptions)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _shopeeOptions = shopeeOptions.Value;
        }

        public Task<T> ExecuteAsync<T>(IShopeeRequest<T> request) where T : IShopeeResponse
        {
            throw new System.NotImplementedException();
        }
    }
}