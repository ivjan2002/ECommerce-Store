using Microsoft.AspNetCore.Mvc;

namespace BestStoreMVC.Controllers
{
    public class StoreController : Controller {

        public readonly ApplicationDBContext context;

        public StoreController(ApplicationDBContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var products = context.Products.OrderByDescending(p=>p.Id).ToList();
            ViewBag.Products = products;
            return View();
        }
    }