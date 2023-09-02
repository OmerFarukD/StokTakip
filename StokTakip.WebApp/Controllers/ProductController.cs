using Microsoft.AspNetCore.Mvc;
using StokTakip.WebApp.Models;
using StokTakip.WebApp.Repository;

namespace StokTakip.WebApp.Controllers
{


    public class ProductController : Controller
    {


        private readonly BaseDbContext _baseDbContext;

        // Constructor args Dependency Injection

        public ProductController(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
        }
        public IActionResult Index()
        {
            var products = _baseDbContext.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            _baseDbContext.Add(product);
            _baseDbContext.SaveChanges();
            return RedirectToAction("Index","Product");
        }

        public IActionResult Details(int id)
        {
            Product? product = _baseDbContext.Products.SingleOrDefault(x => x.Id == id);
            return View(product);
        }



    }
}
