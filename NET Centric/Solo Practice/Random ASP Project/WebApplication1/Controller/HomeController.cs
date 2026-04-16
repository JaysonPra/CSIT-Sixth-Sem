using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var myUser = new User
        {
            Id = 1,
            Name = "Jayson",
            Email = "jaysonyt2@gmail.com"
        };

        return View(myUser);
    }
}