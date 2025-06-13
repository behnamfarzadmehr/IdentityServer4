using System.Security.Claims;
using Duende.IdentityServer.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using IdentityServer.Models;

namespace IdentityServer.Controllers
{
    public class AccountController : Controller
    {
        private readonly IIdentityServerInteractionService _interaction;

        public AccountController(IIdentityServerInteractionService interaction)
        {
            _interaction = interaction;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            // Ensure returnUrl is valid
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                returnUrl = "~/";
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login()
        {
            return Redirect("~/");
        }

        [HttpGet]
        public async Task<IActionResult> Logout(string logoutId)
        {
            
            return Redirect("~/");
        }
    }
}
