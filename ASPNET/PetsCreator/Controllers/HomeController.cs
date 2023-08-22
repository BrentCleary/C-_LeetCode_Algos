using System.Diagnostics;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
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

    [HttpGet("/")]
    public IActionResult Index()
    {

        return View();
    }


    [HttpGet("/pet/all")]
    public IActionResult AllPets()
    {
        List<Pet> AllPets = _context.Pets.ToList();

        

        return View(AllPets);

    }

    // Get one Pet Query for OnePet View
    [HttpGet("pet/{id}")]
    public IActionResult OnePet(int id)
    {

        Pet? OnePet = _context.Pets.FirstOrDefault(p => p.PetId == id);

        return View(OnePet);
    }


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

    [HttpGet("/pet/new")]
    public IActionResult NewPet(Pet pet)
    {

        return View("NewPet", pet);
    }


    [HttpGet("/pet/edit/{id}")]
    public IActionResult EditPet(int id)
    {
        Pet? OnePet = _context.Pets.FirstOrDefault(p => p.PetId == id);


        return View(OnePet);
    }

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
