using Microsoft.AspNetCore.Mvc;
using MyFirstProject_W2.Components.Model;

namespace MyFirstProject_W2.Components.Controller;

public class HomeController : Microsoft.AspNetCore.Mvc.Controller
{
    public IActionResult Index()
    {
        return View(new IndexModel());
    }
    [HttpPost]
    public IActionResult Index(IndexModel model)
    {
        if (string.IsNullOrEmpty(model.Name))
        {
            ModelState.AddModelError("", "Name is required.");
            return View(model);
        }
        return RedirectToAction(nameof(Success));
        
    }

    public IActionResult Success()
    {
        return View();
    }
}