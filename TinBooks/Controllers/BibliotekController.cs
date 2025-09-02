using Microsoft.AspNetCore.Mvc;

namespace TinBooks.Controllers;

public class BibliotekController : Controller
{


    public IActionResult index()
    {
        return View();
    }
}

