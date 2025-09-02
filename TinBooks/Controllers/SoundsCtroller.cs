using Microsoft.AspNetCore.Mvc;

namespace TinBooks.Controllers;

public class SoundsCtroller : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}