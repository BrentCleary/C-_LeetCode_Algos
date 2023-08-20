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

        if(name == null)
        {
            HttpContext.Session.SetString("UserName", "TempName");
        }
        else
        {
            HttpContext.Session.SetString("UserName", name);

        }

        if(HttpContext.Session.GetInt32("ResultValue") == null)
        {
            HttpContext.Session.SetInt32("ResultValue", 10);
        }

        return RedirectToAction("Result");
    }


    public IActionResult Result()
    {
        // HttpContext.Session.SetInt32("ResultValue", 0);
        int? result = HttpContext.Session.GetInt32("ResultValue");
        string? currentUser = HttpContext.Session.GetString("UserName");

        return View("Result");
    }

    // Update Session Method
    [HttpGet("/process/{oper}/{num}")]
    public IActionResult Process(string oper, int num = 10)
    {
        // get the number from Session
        int? Number = HttpContext.Session.GetInt32("ResultValue");

        // Conditional to Change value
        if(oper == "plus")
        {
            Number += num;
        }
        else if(oper == "minus")
        {
            Number -= num;
        }
        else if (oper == "times")
        {
            Number *= num;
        }
        else if(oper == "random")
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, num);
            Number += randomNum;
        }

        HttpContext.Session.SetInt32("ResultValue", (int)Number);
    
        return RedirectToAction("Result");
    
    }


    [HttpGet("/process/clear")]
    public IActionResult ClearSession()
    {
        HttpContext.Session.SetInt32("ResultValue", 0);

        return RedirectToAction("Result");
    }


    [HttpPost("/logout")]
    public IActionResult LogOut()
    {
        HttpContext.Session.SetInt32("ResultValue", 0);
        HttpContext.Session.SetString("UserName", "");

        return RedirectToAction("Index");
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
