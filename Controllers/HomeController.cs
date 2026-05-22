using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Bibilotec_MVC_DEV.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
