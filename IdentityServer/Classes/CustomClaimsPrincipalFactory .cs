using Duende.IdentityServer.Models;
using System.Security.Claims;
using Duende.IdentityServer.Services;
using Microsoft.AspNetCore.Identity;
using Duende.IdentityModel;
using Microsoft.Extensions.Options;

namespace IdentityServer.Classes;

public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory<IdentityUser>
{
    public CustomClaimsPrincipalFactory(UserManager<IdentityUser> userManager, IOptions<IdentityOptions> optionsAccessor)
        : base(userManager, optionsAccessor) { }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
    {
        var identity = await base.GenerateClaimsAsync(user);
        identity.AddClaim(new Claim(JwtClaimTypes.Subject, user.Id));
        return identity;
    }
}
