// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace DojoSurvey2.Controllers;   
public class SurveyController : Controller   // Remember inheritance?    
{      
    [HttpGet("/")] // We will go over this in more detail on the next page    
    public ViewResult Form()        
    {            
      return View("Form");        
    }


    [HttpPost("submit")]
    public RedirectToActionResult Submit(string name, string language, string location, string message)
    {
      System.Console.WriteLine($"name: {name}");
      System.Console.WriteLine($"language: {language}");
      System.Console.WriteLine($"location: {location}");
      System.Console.WriteLine($"message: {message}");

      return RedirectToAction("Results", new { myName = name, myLanguage = language} );
    }

    [HttpGet("results")]
    public IActionResult Results(string myName, string myLanguage)
    {

      ViewBag.myName = myName;
      ViewBag.myLanguage = myLanguage;

      return View("Results");
    }


    // HttpGet("results")
    // public IActionResult Results()
    // {

    // }
}

