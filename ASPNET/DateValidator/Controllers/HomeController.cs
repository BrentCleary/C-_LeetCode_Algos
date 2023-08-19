using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DateValidator.Models;

namespace DateValidator.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("/submitdate")]
    public IActionResult SubmitDate(Date date)
    {
        if(ModelState.IsValid)
        {
            Console.WriteLine(date.CurrentDate);
            Console.WriteLine(date.TestVar);

            return View("Results", date);
        }
        else
        {
            Console.WriteLine("---------- Model state is Invalid -------");
            return View("Index");
        }
    }

    [HttpGet("/dateresult")]
    public IActionResult Results()
    {
        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
