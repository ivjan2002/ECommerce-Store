using Microsoft.AspNetCore.Mvc;

namespace BestStoreMVC.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
