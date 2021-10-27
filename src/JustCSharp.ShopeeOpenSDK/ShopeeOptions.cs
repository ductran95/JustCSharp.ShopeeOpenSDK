namespace JustCSharp.ShopeeOpenSDK
{
    public class ShopeeOptions
    {
        public int PartnerId { get; set; }
        public int ShopId { get; set; }
        public int? MainAccountId { get; set; }
        public int? MerchantId { get; set; }
        public string RedirectUrl { get; set; }
        public string ApiUrl = ShopeeConstants.ProdApiUrl;

        public void UseTestEnvironment()
        {
            this.ApiUrl = ShopeeConstants.TestApiUrl;
        }
        
        public void UseProdEnvironment()
        {
            this.ApiUrl = ShopeeConstants.ProdApiUrl;
        }

        public void CheckValid()
        {
            var isValid = !string.IsNullOrEmpty(ApiUrl)
                   && !string.IsNullOrEmpty(RedirectUrl)
                   && PartnerId > 0 && ShopId > 0
                   && (MainAccountId == null || MainAccountId > 0)
                   && (MerchantId == null || MerchantId > 0);

            if (!isValid)
            {
                throw new ShopeeException(ShopeeErrors.OptionNotValid);
            }
        }
    }
}