using SICCD.Models;
using Microsoft.AspNetCore.Mvc;


namespace SICCD.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel modelo)
        {
            return View(modelo);
        }
    }
}