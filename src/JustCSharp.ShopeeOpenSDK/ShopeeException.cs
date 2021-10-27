using System;

namespace JustCSharp.ShopeeOpenSDK
{
    public class ShopeeException: Exception
    {
        public ShopeeException()
        {
        }

        public ShopeeException(string messages) : base(messages)
        {
        }

        public ShopeeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}