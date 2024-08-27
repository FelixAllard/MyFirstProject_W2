using BlazorApp1.Components.Model;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Components.Controller;

public class HomeController : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly ILogger<HomeController> _logger;
    private static List<Product> products = new List<Product>
    {
        new Product{ Id = 20, Description = "Asdasd", Name = "asdasd", Price = 1000}
        
    };

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
        
    }

    public IActionResult Details(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        return View(product);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}