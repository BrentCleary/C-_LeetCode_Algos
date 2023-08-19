using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModels.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace DojoSurveyModels.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Index Page Survey

    [HttpGet("/")]
    public IActionResult Index()
    {

        return View();
    }

    // Post Request

    [HttpPost("/process")]
    public IActionResult Process(DojoModelsSurvey survey)
    {

        if(ModelState.IsValid)
        {
            System.Console.WriteLine(survey.Name);
            System.Console.WriteLine(survey.Location);
            System.Console.WriteLine(survey.Language);
            System.Console.WriteLine(survey.Message);
            
            return View("Results", survey);
        }
        else
        {
            return View("Index");
        }


    }


    // Results Process

    [HttpGet("/results")]
    public IActionResult Results()
    {

        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
