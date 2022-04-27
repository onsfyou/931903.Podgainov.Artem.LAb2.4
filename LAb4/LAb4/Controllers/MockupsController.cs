using Microsoft.AspNetCore.Mvc;
using LAb4.Services;

namespace LAb4.Controllers
{
    public class MockupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(string FirstName, string LastName, int BirthDay, string BirthMonth, int BirthYear, string Gender)
        {
            if (ModelState.IsValid)
            {
                SignUpService.AccSet1(FirstName, LastName, BirthDay, BirthMonth, BirthYear, Gender);
                return RedirectToAction("SignUpNext");
            }
            return View();
        }

        [HttpGet]
        public IActionResult SignUpNext()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUpNext(string Email, string Password, string ConPassword, string? Remember)
        {
            if (ModelState.IsValid)
            {
                if (Password != ConPassword)
                    return RedirectToAction("SignUpNext");
                SignUpService.AccSet2(Email, Password, Remember);
                return RedirectToAction("SignUpCredentials");
            }
            return View();
        }
        public IActionResult SignUpCredentials()
        {
            ViewData["FirstName"] = SignUpService.FirstName;
            ViewData["LastName"] = SignUpService.LastName;
            ViewData["BirthDay"] = SignUpService.BirthDay;
            ViewData["BirthMonth"] = SignUpService.BirthMonth;
            ViewData["BirthYear"] = SignUpService.BirthYear;
            ViewData["Email"] = SignUpService.Email;
            ViewData["Password"] = SignUpService.Password;
            return View();
        }
        [HttpGet]
        public IActionResult PasswordReset()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PasswordReset(string Email)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("PasswordResetNext");
            }
            return View();
        }
        [HttpGet]
        public IActionResult PasswordResetNext()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PasswordResetNext(string Code)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("PasswordResetComplete");
            }
            return View();
        }
        public IActionResult PasswordResetComplete()
        {
            return View();
        }
    }
}
