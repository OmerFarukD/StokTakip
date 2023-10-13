using Microsoft.AspNetCore.Mvc;
using StokTakip.WebApp1.Models;

namespace StokTakip.WebApp1.Controllers;

public class ProductController : Controller
{

    private List<Product> _products;

    public ProductController()
    {
        _products = new List<Product>()
        {
            new Product{Id=1,Name="Msi", Description="Oyun bilgisayarı",Price=25000,Stock=25},
            new Product{Id=2,Name="Monster", Description="Oyun bilgisayarı",Price=27000,Stock=25}
        };
    }


    public IActionResult Anasayfa()
    {
        return View(_products);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        _products.Add(product);
        return RedirectToAction("Anasayfa");
    }

}
