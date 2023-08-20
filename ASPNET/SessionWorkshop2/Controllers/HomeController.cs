using System.Net.WebSockets;
using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionWorkshop2.Models;

namespace SessionWorkshop2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    [HttpGet("/")]
    public IActionResult Index()
    {



        return View();
    }


    [HttpPost("/process")]
    public IActionResult Process(string name)
    {

        HttpContext.Session.SetString("UserName", name);

        return RedirectToAction("Result");
    }


    public IActionResult Result()
    {
        HttpContext.Session.SetInt32("ResultValue", 0);
        int? result = HttpContext.Session.GetInt32("ResultValue");
        string? currentUser = HttpContext.Session.GetString("UserName");

        return View("Result");
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
