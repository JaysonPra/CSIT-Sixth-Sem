using Microsoft.AspNetCore.Mvc;
using NCITWeb.Models;

namespace NCITWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public IActionResult Create()
        {
            Product p1 = new()
            {
                Id = 1,
                Name = "Test",
                Price = 45
            };

            ViewData["name"] = "Ram";
            ViewBag.age = 20;
            return View(p1);
        }

    }
}
