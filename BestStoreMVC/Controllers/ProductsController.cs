using BestStoreMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace BestStoreMVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDBContext context;
        public ProductsController(ApplicationDBContext context)
        {
            this.context = context;

        }
        public IActionResult Index()
        {
            var products = context.Products.OrderByDescending(p=>p.Id).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
