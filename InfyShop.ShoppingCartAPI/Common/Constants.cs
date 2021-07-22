using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfyShop.ShoppingCartAPI.Common
{
    public class Constants
    {
        public const string ShoppingCartConnectionString = "ShoppingCartConnectionString";
        public const string BlobContainerInfyShopUrl = "https://cleanarchstorageaccount.blob.core.windows.net/infyshop/";
        public const string CleanArchAPI = "CleanArchAPI";
        public const string ProductAPIPath = "/api/products/";
        public const string ServiceUrls = "ServiceUrls";
        public const string ProductAPI = "ProductAPI";


        public const string IdentityServerAuthority = "IdentityServerAuthority";
        public const string Bearer = "Bearer";
        public const string infyshop = "infyshop";


        public const string checkoutqueue = "checkoutqueue";
        public const string checkoutmessagetopic = "checkoutmessagetopic";
    }
}
