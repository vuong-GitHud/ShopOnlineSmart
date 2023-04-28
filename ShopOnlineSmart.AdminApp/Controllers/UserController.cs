using Microsoft.AspNetCore.Mvc;

namespace ShopOnlineSmart.AdminApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
