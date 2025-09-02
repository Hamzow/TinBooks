using Microsoft.AspNetCore.Mvc;

namespace TinBooks.Controllers;

public class LoginController : Controller
{
    // GET
    public IActionResult index()
    {
        return View();
    }
}