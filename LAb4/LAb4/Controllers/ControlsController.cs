using Microsoft.AspNetCore.Mvc;

namespace LAb4.Controllers
{
    public class ControlsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TextBox()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TextBox(string text)
        {
            ViewData["Text"] = text;
            return View();
        }

        [HttpGet]
        public IActionResult TextArea()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TextArea(string text)
        {
            ViewData["Text"] = text;
            return View();
        }

        [HttpGet]
        public IActionResult CheckBox()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckBox(bool IsSelected)
        {
            ViewData["Text"] = IsSelected;
            return View();
        }

        [HttpGet]
        public IActionResult Radio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Radio(string text)
        {
            ViewData["Text"] = text;
            return View();
        }

        [HttpGet]
        public IActionResult DropDownList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DropDownList(string text)
        {
            ViewData["Text"] = text;
            return View();
        }

        [HttpGet]
        public IActionResult ListBox()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ListBox(string[] months)
        {
            string result = "";
            foreach (string c in months)
            {
                result += c;
                result += " ";
            }
            ViewData["Months"] = result;
            return View();
        }
    }
}
