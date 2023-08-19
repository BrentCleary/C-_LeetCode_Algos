using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModels.Models;

namespace DojoSurveyModels.Controllers;

public class DogController : Controller
{
    private readonly ILogger<DogController> _logger;

    public DogController(ILogger<DogController> logger)
    {
        _logger = logger;
    }

    // Post Request

    [HttpPost("/processdog")]
    public IActionResult ProcessDog(Dog dog)
    {

        System.Console.WriteLine(dog.DogName);
        System.Console.WriteLine(dog.DogAge);
        System.Console.WriteLine(dog.DogGoodboy);

        return View("DogResults", dog);
    }


    // Results Process

    [HttpGet("/dogresults")]
    public IActionResult DogResults()
    {

        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
