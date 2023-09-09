using System.Net;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Identity;
using HowlsMovingDogPark.Models;


namespace HowlsMovingDogPark.Controllers;

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

  [SessionCheck]
  [HttpGet("/boardings")]
  public IActionResult BoardingIndex()
  {

    List<Boarding> AllBoardings = _context.Boardings
    .Include(b => b.UserReservations).ToList();

    return View("AllBoardings", AllBoardings);
  }


  [HttpPost("/boardings/{boardingId}/reservation")]
  public IActionResult ReserveBoarding(int boardingId)
  {
    if(userId == null)
    {
      return RedirectToAction("NewUser");
    }


    UserBoardingReservation? existingReservation = _context.UserBoardingReservations.FirstOrDefault(ubr => ubr.UserId == userId && ubr.BoardingId == boardingId);

    if(existingReservation != null)
    {
      _context.Remove(existingReservation);
    }
    else
    {
      UserBoardingReservation newReservation = new UserBoardingReservation()
      {
        UserId = (int)userId,
        BoardingId = boardingId
      };
      
      // Console Debug Check
      System.Console.WriteLine("------ UserId ------" + newReservation.UserId + "------------");
      System.Console.WriteLine("------ BoardingId ------" + newReservation.BoardingId + "------------");

      _context.UserBoardingReservations.Add(newReservation);
    } 

    

    _context.SaveChanges();

    return RedirectToAction("BoardingIndex");
  }







  public IActionResult Privacy()
  {
      return View();
  }



}