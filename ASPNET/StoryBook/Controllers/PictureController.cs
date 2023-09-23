using System.Net;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using StoryBook.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace StoryBook.Controllers;

public class PictureController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;
    
    public PictureController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/picture/new")]
    public IActionResult CreatePicture()
    {
      

      return View();
    }


    [HttpPost("/picture/submit")]
    public IActionResult SubmitPicture(Picture newPicture)
    {

      if(!ModelState.IsValid)
      {
        return View("CreatePicture");
      }
    
      _context.Add(newPicture);

      Console.WriteLine("+_+_+_+_+_+ +" + newPicture.ImageData + "+_+_+_+_+_+_+_+_");

      _context.SaveChanges();

      return RedirectToAction("Index", "Home");
      
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
