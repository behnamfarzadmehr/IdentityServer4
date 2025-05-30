using Duende.IdentityServer.Models;
using Duende.IdentityServer;

namespace IdentityServer;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };

    public static IEnumerable<Client> Clients =>
        new List<Client>
        {
        new Client
{
    ClientId = "blazor_hybrid",
    ClientSecrets = { new Secret("secret".Sha256()) },
    AllowedGrantTypes = GrantTypes.Code,
    RequirePkce = true,
    RequireClientSecret = false,
    RedirectUris = { "https://localhost:7079/signin-oidc" },
    PostLogoutRedirectUris = { "https://localhost:7079/signout-callback-oidc" },
    AllowedScopes =
    {
        IdentityServerConstants.StandardScopes.OpenId,
        IdentityServerConstants.StandardScopes.Profile,
        "api1"
    },
    AllowOfflineAccess = true
}
        };
}
