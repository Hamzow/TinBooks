using Microsoft.AspNetCore.Mvc;

namespace TinBooks.Controllers;

public class BestallaController : Controller
{
    // GET
    public IActionResult index()
    {
        return View();
    }
}