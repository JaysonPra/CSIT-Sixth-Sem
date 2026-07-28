using EFCorePractice.Data;
using EFCorePractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCorePractice.Controllers;

public class EmployeeController: Controller
{
    private AppDbContext context = null;
    public EmployeeController(AppDbContext context)
    {
        this.context = context;
    }

    public ActionResult Index()
    {
        var employees = context.Employees.ToList();

        return View(employees);
    }

    public ActionResult Details(int id)
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Employee emp)
    {
        context.Employees.Add(emp);
        context.SaveChanges();

        return Content("Data Inserted Successfully!");
    }
}