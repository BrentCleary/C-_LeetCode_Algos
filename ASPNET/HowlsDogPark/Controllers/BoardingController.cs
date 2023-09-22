using System.Net;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Identity;
using HowlsDogPark.Models;


namespace HowlsDogPark.Controllers;

public class BoardingController : Controller
{
  private int? userId
  {
    get
    {
      return HttpContext.Session.GetInt32("UserId");
    }
  }

  private readonly ILogger<UserController> _logger;
  private MyContext _context;

  public BoardingController(ILogger<UserController> logger, MyContext context)
  {
    _logger = logger;
    _context = context;
  }

    // ------- Boarding ROUTES -----------
  // ----- Create Boarding (FORM)

  [SessionCheck]
  [HttpGet("/boarding/new")]
  public IActionResult NewBoarding()
  {

    // VIEWBAG - Passing Logged Users Dogs as Dictionary
    User? currentUser = _context.Users.Include(d => d.AllDogs).FirstOrDefault(u => u.UserId == userId); 

    List<Dog> userDogList = currentUser.AllDogs;

    Dictionary<string, int> dogDictionary = new Dictionary<string, int>();
    foreach(Dog dog in userDogList)
    {
      dogDictionary.Add(dog.Name, dog.DogId);
    }

    ViewBag.dogDictionary = dogDictionary;

    return View("BoardingCreate");
  }

    // ----- Create Boarding (POST)

  [HttpPost("/boarding/create")]
  public IActionResult CreateBoarding(Boarding newBoarding)
  {
    if(ModelState.IsValid)
    {
      _context.Add(newBoarding);
      _context.SaveChanges();

      return RedirectToAction("ShowUser", "User", new {id = userId });
    }
    else
    {
      return View("BoardingCreate");
    }
  }



  public IActionResult Privacy()
  {
      return View();
  }



}