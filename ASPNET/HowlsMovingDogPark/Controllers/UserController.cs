using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Identity;
using HowlsMovingDogPark.Models;


namespace HowlsMovingDogPark.Controllers;

public class UserController : Controller
{
  private readonly ILogger<UserController> _logger;
  private MyContext _context;

  public UserController(ILogger<UserController> logger, MyContext context)
  {
    _logger = logger;
    _context = context;
  }

  // ------------ USER CREATE ROUTES -----------

  [HttpGet("/users/new")]
  public IActionResult NewUser()
  {

    return View("~/Views/User/UserCreateLogin.cshtml");
  }


  [HttpPost("/users/create")]
  public IActionResult CreateUser(User newUser)
  {
    if(ModelState.IsValid)
    {
      PasswordHasher<User> Hasher = new PasswordHasher<User>();
      newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
      _context.Add(newUser);
      _context.SaveChanges();
      HttpContext.Session.SetInt32("UserId", newUser.UserId);
      return RedirectToAction("Index");
    }
    else
    {
      return View("UserCreateLogin");
    }

  }

  [HttpGet("/users")]
  public IActionResult UserIndex()
  {
    List<User> AllUsers = _context.Users.ToList();
    return View("AllUsers", AllUsers);
  }





  public IActionResult Privacy()
  {
      return View();
  }

}

