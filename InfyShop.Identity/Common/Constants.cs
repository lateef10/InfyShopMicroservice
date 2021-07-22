using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfyShop.Identity.Common
{
    public class Constants
    {
        public const string IdentityServerConnectionString = "IdentityServerConnectionString";

        public static string RedirectUris { get; set; }
        public static string PostLogoutRedirectUris { get; set; }
        //public const string RedirectUris = "http://webfrontend/signin-oidc"; //"https://localhost:44385/signin-oidc"
        //public const string PostLogoutRedirectUris = "http://webfrontend/signout-callback-oidc";  //"https://localhost:44385/signout-callback-oidc"

        public const string RedirectUrisStr = "RedirectUris";
        public const string PostLogoutRedirectUrisStr = "PostLogoutRedirectUris";
    }
}
