using Microsoft.AspNetCore.Mvc;

namespace TinBooks.Controllers;

public class SkrivareController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}