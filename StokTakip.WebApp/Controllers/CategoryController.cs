using Microsoft.AspNetCore.Mvc;

namespace StokTakip.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
