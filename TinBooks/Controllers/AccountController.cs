using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using TinBooks.Models;
namespace TinBooks.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl; 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Account account, string returnUrl)
        {
            bool accountValid = account.Username == "Hamza" && account.Password == "Hamza1122";
            
            if (!accountValid)
            {
                ViewBag.ErrorMessage = "Login failed: Wrong username or password";
                ViewBag.ReturnUrl = returnUrl;
                return View();
            }
            
            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            identity.AddClaim(new Claim(ClaimTypes.Name, account.Username));
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
                
            if (string.IsNullOrEmpty(returnUrl))
            {
                return RedirectToAction("Index", "Home");
            }
            
            return Redirect(returnUrl);
        }
    }
}