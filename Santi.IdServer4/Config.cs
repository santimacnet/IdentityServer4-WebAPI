using IdentityServer4.Models;
using System.Collections.Generic;

namespace Santi.IdServer4
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {
                new ApiResource("Santander", "Santander APIs")
                {
                    Scopes = {
                        "santander.fullaccess"
                    }
                }
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("santander.fullaccess"),
             };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientName = "Santander Client",
                    ClientId = "santander-clientid",
                    ClientSecrets = { new Secret("A7D130AA-1642-4879-BF65-F37177D9096D".Sha256()) },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes =
                    {
                        "santander.fullaccess"
                    }
                }
            };
    }
}