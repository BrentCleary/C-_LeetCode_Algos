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

      return RedirectToAction("BoardingIndex");
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