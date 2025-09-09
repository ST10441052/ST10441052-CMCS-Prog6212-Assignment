using Microsoft.AspNetCore.Mvc;

namespace CMCSPrototype.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login() => View();
        public IActionResult Register() => View();
        public IActionResult AccessDenied() => View();
        public IActionResult Logout() => RedirectToAction("Login");
    }
}
