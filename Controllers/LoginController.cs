using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace eBook.Controllers {
    public class Login : Controller {
        [HttpGet]
        public IActionResult Exit() {
            
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
            //return RedirectToAction("Enter", "Login");
        }


        [HttpPost]
        public IActionResult Enter() {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "Email"),
                new Claim("FullName", "FullName"),
                new Claim(ClaimTypes.Role, "Administrator"),
            };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return RedirectToAction("Index", "Home");

        }
    }
}