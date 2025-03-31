using Microsoft.AspNetCore.Mvc;

namespace BestStoreMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
