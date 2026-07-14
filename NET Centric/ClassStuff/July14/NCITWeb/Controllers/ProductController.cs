using Microsoft.AspNetCore.Mvc;

namespace NCITWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public IActionResult Create()
        {
            return View();
        }

    }
}
