using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies; 
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace TinBooks.Controllers
{
    [Authorize] 
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
        public async Task<IActionResult> SignOutUser()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme); 
            return RedirectToAction("Index", "Home"); 
        }
    }
}