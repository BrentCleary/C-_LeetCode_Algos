using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers;

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


    [HttpPost("/reg-register")]
    public IActionResult RegistrationSubmit(Registration registration)
    {
        if(ModelState.IsValid)
        {
            Console.WriteLine(registration.Name);
            Console.WriteLine(registration.Email);
            Console.WriteLine(registration.DateOfBirth);
            Console.WriteLine(registration.Password);
            Console.WriteLine(registration.FavoriteOddNum);
            
            return RedirectToAction("RegistrationResults", registration);
        }
        else
        {
            return View("Index");
        }

    }


        [HttpGet("/reg-results")]
    public IActionResult RegistrationResults()
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
