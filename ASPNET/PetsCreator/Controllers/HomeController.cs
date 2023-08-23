using System.Diagnostics;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Identity;
using PetsCreator.Models;

namespace PetsCreator.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context; 

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }


// =============== HOMEPAGE (INDEX) ===============

    [HttpGet("/")]
    public IActionResult Index()
    {

        return View();
    }


// =============== VIEW PET ROUTES ===============


    // ---------- View All Pets Page----------
    [SessionCheck]
    [HttpGet("/pet/all")]
    public IActionResult AllPets()
    {
        List<Pet> AllPets = _context.Pets.ToList();

        return View(AllPets);
    }

    // ---------- View One Pet Page ----------

    // Get one Pet Query for OnePet View
    [HttpGet("pet/{id}")]
    public IActionResult OnePet(int id)
    {
        Pet? OnePet = _context.Pets.FirstOrDefault(p => p.PetId == id);

        return View(OnePet);
    }



// =============== CREATE PET ROUTES ===============


    // ---------- Create One Pet (Form) ----------

    [HttpGet("/pet/new")]
    public IActionResult NewPet(Pet pet)
    {

        return View("NewPet", pet);
    }


    // ---------- Create One Pet (Post) ----------

    [HttpPost("/pet/create")]
    public IActionResult CreatePet(Pet newPet)
    {
        if(ModelState.IsValid)
        {

            _context.Add(newPet);
            _context.SaveChanges();

            Console.WriteLine(newPet.Name);
            Console.WriteLine(newPet.Species);
            Console.WriteLine(newPet.Description);

            return RedirectToAction("NewPet", newPet);        
        }
        else
        {
            return View("Index");
        }
    }


// =============== EDIT PET ROUTES ===============


    // ---------- Edit One Pet (Form) ----------

    [HttpGet("/pet/edit/{id}")]
    public IActionResult EditPet(int id)
    {
        Pet? OnePet = _context.Pets.FirstOrDefault(p => p.PetId == id);

        return View(OnePet);
    }

    // ---------- Edit One Pet (Post) ----------

    [HttpPost("/pet/submitedit/{id}")]
    public IActionResult SubmitEdit(int id, Pet NewVersion)
    {

        Pet? OldPet = _context.Pets.FirstOrDefault(p => p.PetId == id);
        if(ModelState.IsValid)
        {
            OldPet.Name = NewVersion.Name;
            OldPet.Species = NewVersion.Species;
            OldPet.Description = NewVersion.Description;
            OldPet.UpdatedAt = DateTime.Now;
            _context.SaveChanges();

            return RedirectToAction("OnePet", new {id = OldPet.PetId});
        }
        else
        {
            return View("EditPet", OldPet);
        }
    }


// =============== DELETE PET ROUTE ===============

    // ---------- Delete One Pet (Post) ----------

    [HttpPost("/pet/delete/{id}")]
    public IActionResult DeletePet(int id)
    {

        System.Console.WriteLine("----------------Deleting pet with id: " + id + "-------------");

        Pet? petToDelete = _context.Pets.SingleOrDefault(p => p.PetId == id );
        _context.Pets.Remove(petToDelete);
        _context.SaveChanges();

        return RedirectToAction("AllPets");
    }






// =============== CREATE USER ROUTE ===============

    // ---------- Create One User (Post) ----------

    [HttpPost("/user/create")]
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
            return View("Index");
        }
    }

    // ---------- Login One User (Post) ----------

    [HttpPost("/user/login")]
    public IActionResult LoginUser(LogUser loginUser)
    {
        if(ModelState.IsValid)
        {
            User? userInDb = _context.Users.FirstOrDefault(u => u.Email == LoginUser.LEmail);
            if(userInDb == null)
            {
                ModelState.AddModelError("LEmail", "Invalid Email/Password");
                return View("Index");
            }
            PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
            var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LPassword);
            if(result == 0)
            {
                ModelState.AddModelError("LEmail", "Invalid Email/Password");
                return View("Index");
            }
            else
            {
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Index");
            }
        }
        else
        {
            return View("Index");
        }


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



// Session Check for logged in User

// Apply [SessionCheck] to all routes user must be logged in to view

public class SessionCheckAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        int? userId = context.HttpContext.Session.GetInt32("UserId");
        if(userId == null)
        {
            context.Result = new RedirectToActionResult("Index", "Home", null);
        }
    }
}
