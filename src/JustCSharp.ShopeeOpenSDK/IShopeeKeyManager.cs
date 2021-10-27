namespace JustCSharp.ShopeeOpenSDK
{
    public interface IShopeeKeyManager
    {
        string AuthorizationCode { get; set; }
        string AccessToken { get; set; }
        string RefreshToken { get; set; }
    }
}