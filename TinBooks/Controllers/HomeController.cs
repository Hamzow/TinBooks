using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TinBooks.Models;

namespace TinBooks.Controllers;

public class HomeController : Controller
{
 

    public IActionResult index()
    {
        return View();
    }
}

