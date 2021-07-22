using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfyShop.OrderAPI.Common
{
    public class Constants
    {
        public const string OrderConnectionString = "OrderConnectionString";
        public const string BlobContainerInfyShopUrl = "https://cleanarchstorageaccount.blob.core.windows.net/infyshop/";
        public const string CleanArchAPI = "CleanArchAPI";
        public const string ServiceUrls = "ServiceUrls";
        public const string ProductAPI = "ProductAPI";


        public const string IdentityServerAuthority = "IdentityServerAuthority";
        public const string Bearer = "Bearer";
        public const string infyshop = "infyshop";


        public const string ServiceBusConnectionString = "ServiceBusConnectionString";
        public const string checkoutqueue = "checkoutqueue";
        public const string checkoutmessagetopic = "checkoutmessagetopic";
        public const string InfyShopOrderSubscription = "InfyShopOrderSubscription";
        public const string InfyShopOrderPaymentSubscription = "InfyShopOrderPaymentSubscription";
        public const string OrderPaymentProcessTopics = "orderpaymentprocesstopic";
        public const string OrderUpdatePaymentResultTopic = "orderupdatepaymentresulttopic";
    }
}
