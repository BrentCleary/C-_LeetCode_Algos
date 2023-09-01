using System.Net;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HowlsMovingDogPark.Models;


namespace HowlsMovingDogPark.Controllers;

public class DogController : Controller
{
  private readonly ILogger<DogController> _logger;
  private MyContext _context;

  public DogController(ILogger<DogController> logger, MyContext context)
  {
    _logger = logger;
    _context = context;
  }


  // ------- DOG ROUTES -----------
  // ----- Create Dog (FORM)

  [SessionCheck]
  [HttpGet("/dogs/new")]
  public IActionResult NewDog()
  {

    
    int? currentUserId = HttpContext.Session.GetInt32("UserId");
    ViewBag.currentUserId = currentUserId.Value;
    

    return View("~/Views/Dog/DogCreate.cshtml");
  }

  // ----- Create Dog (POST)


  [HttpPost("/dogs/create")]
  public IActionResult CreateDog(Dog newDog)
  {

    if(ModelState.IsValid)
    {

      _context.Add(newDog);
      _context.SaveChanges();
      return RedirectToAction("DogIndex");
    }
    else
    {
      return View("DogCreate");
    }
  }

    // ----- All Dogs (VIEW)

  [HttpGet("/dogs")]
  public IActionResult DogIndex()
  {

    List<Dog> AllDogs = _context.Dogs.ToList();

    return View("AllDogs", AllDogs);
  }

  // ---- Edit Dog (VIEW)

  [HttpGet("/dogs/{id}/edit")]
  public IActionResult EditDog()
  {

    return View();
  }


  public IActionResult Privacy()
  {
      return View();
  }


}