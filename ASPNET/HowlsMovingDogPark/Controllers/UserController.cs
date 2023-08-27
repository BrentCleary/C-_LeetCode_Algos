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

  // ------- USER ROUTES -----------
  // ----- Create User (FORM)

  [HttpGet("/users/new")]
  public IActionResult NewUser()
  {

            // Test this
    ViewBag.SessionKey = HttpContext.Session.GetInt32("UserId");
    ViewBag.Test = "Just a test";

    return View("~/Views/User/UserCreateLogin.cshtml");
  }

  // ----- Create User (POST)

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
      return RedirectToAction("UserIndex");
    }
    else
    {
      return View("UserCreateLogin");
    }
  }

  // ----- Display All Users

  [SessionCheck]
  [HttpGet("/users")]
  public IActionResult UserIndex()
  {
    List<User> AllUsers = _context.Users.ToList();
    return View("AllUsers", AllUsers);
  }


  // ----- User Login (POST)

  [HttpPost("/users/login")]
  public IActionResult LoginUser(LogUser loginUser)
  {
    if(ModelState.IsValid)
    {
      User? userInDb = _context.Users.FirstOrDefault(u => u.Email == loginUser.LEmail);
      if(userInDb == null)
      {
        ModelState.AddModelError("LEmail", "Invalid Email/Password");
        return View("UserCreateLogin");
      }
      PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
      var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LPassword);
      if(result == 0)
      {
        ModelState.AddModelError("LEmail", "Invalid Email/Password");
        return View("UserCreateLogin");
      }
      else
      {
        HttpContext.Session.SetInt32("UserId", userInDb.UserId);
        System.Console.WriteLine("------------" + HttpContext.Session.GetInt32("UserId") + "------------");

        
        return RedirectToAction("UserIndex");
      }
    }
    else
    {
      return View("UserCreateLogin");
    }
  }



  public IActionResult Privacy()
  {
      return View();
  }

}

    // Session Check for logged in User

    // Apply [SessionCheck] to all routes user must be logged in to view

    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            int? userId = context.HttpContext.Session.GetInt32("UserId");
            if(userId == null)
            {
                context.Result = new RedirectToActionResult("NewUser", "User", null);
            }
        }
    }

