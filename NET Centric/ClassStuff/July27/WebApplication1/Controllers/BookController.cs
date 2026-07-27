using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers;


public class BookController: Controller
{
    private 
    public IActionResult Index()
    {
        return View();
    }
}