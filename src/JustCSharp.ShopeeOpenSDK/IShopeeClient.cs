using System.Threading.Tasks;
using JustCSharp.ShopeeOpenSDK.Request;
using JustCSharp.ShopeeOpenSDK.Response;

namespace JustCSharp.ShopeeOpenSDK
{
    public interface IShopeeClient
    {
        Task<T> ExecuteAsync<T>(IShopeeRequest<T> request) where T : IShopeeResponse;
    }
}