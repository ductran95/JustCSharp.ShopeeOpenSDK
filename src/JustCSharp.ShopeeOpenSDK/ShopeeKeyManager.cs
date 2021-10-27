using System.Threading.Tasks;
using System.Net.Http;
using JustCSharp.ShopeeOpenSDK.Request;
using JustCSharp.ShopeeOpenSDK.Response;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JustCSharp.ShopeeOpenSDK
{
    public class ShopeeKeyManager: IShopeeKeyManager
    {
        private readonly ILogger _logger;
        private readonly ShopeeOptions _shopeeOptions;
        
        public string AuthorizationCode { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public ShopeeKeyManager(ILogger<ShopeeKeyManager> logger, IOptions<ShopeeOptions> shopeeOptions)
        {
            _logger = logger;
            _shopeeOptions = shopeeOptions.Value;
        }
    }
}