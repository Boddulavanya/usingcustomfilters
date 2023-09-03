using Microsoft.AspNetCore.Mvc;

namespace Using_Custom_Filters.Controllers
{
    public class HomeController1 : Controller
    {
        public class AccountController : Controller
        {
            public IActionResult Login()
            {
                return View();
            }
        }
    }
}

