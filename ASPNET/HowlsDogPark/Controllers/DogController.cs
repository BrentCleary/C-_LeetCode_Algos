using System.Net;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HowlsDogPark.Models;


namespace HowlsDogPark.Controllers;

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
    

    return View("~/Views/Dog/CreateDog.cshtml");
  }

  // ----- Create Dog (POST)

  [SessionCheck]
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

  [SessionCheck]
  [HttpGet("/dogs")]
  public IActionResult DogIndex()
  {

    List<Dog> AllDogs = _context.Dogs.ToList();

    return View("AllDogs", AllDogs);
  }

  // ---- Edit Dog (VIEW)

  [HttpGet("/dogs/{id}/edit")]
  public IActionResult EditDog(int id)
  {
    Dog? oneDog = _context.Dogs.FirstOrDefault(d => d.DogId == id);

    return View(oneDog);
  }

    // ---- Edit Dog (POST)
  [HttpPost("/dogs/{id}/update")]
  public IActionResult UpdateDog(int id, Dog newDog)
  {
    Dog oldDog = _context.Dogs.FirstOrDefault(d => d.DogId == id);
    if(ModelState.IsValid)
    {
      oldDog.Name = newDog.Name;
      oldDog.Breed = newDog.Breed;
      oldDog.Weight = newDog.Weight;
      oldDog.Age = newDog.Age;
      oldDog.Notes = oldDog.Notes;
      _context.SaveChanges();
      return RedirectToAction("DogIndex");
    }
    else
    {
      return View("EditDog", oldDog);
    }
  }

    // ---- Delete Dog (POST)
    [HttpPost("/dogs/{id}/delete")]
    public IActionResult DeleteDog(int id)
    {
      Dog? DogToDelete = _context.Dogs.SingleOrDefault(d => d.DogId == id);
      _context.Dogs.Remove(DogToDelete);
      _context.SaveChanges();

      return RedirectToAction("DogIndex");
    }

  public IActionResult Privacy()
  {
      return View();
  }


}