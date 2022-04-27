using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LAb4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}