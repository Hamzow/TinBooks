using Microsoft.AspNetCore.Mvc;

namespace TinBooks.Controllers;

public class LjudbokController : Controller
{
    // GET
    public IActionResult index()
    {
        return View();
    }
}