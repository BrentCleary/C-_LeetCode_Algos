using System.Diagnostics;
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

  public IActionResult Privacy()
  {
      return View();
  }


}