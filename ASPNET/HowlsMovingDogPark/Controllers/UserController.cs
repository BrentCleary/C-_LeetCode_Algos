using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HowlsMovingDogPark.Models;

namespace chefs_dishes.Controllers;

public class UserController : Controller
{
  private readonly ILogger<UserController> _logger;
  private MyContext _context;

  public UserController(ILogger<UserController> logger, MyContext context)
  {
    _logger = logger;
    _context = context;
  }



  public IActionResult Privacy()
  {
      return View();
  }

}