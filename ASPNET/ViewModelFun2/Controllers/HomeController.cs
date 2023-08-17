using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun2.Models;

namespace ViewModelFun2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    // -------- Message Route ---------

    [HttpGet("/")]
    public IActionResult Index()
    {
        string loremIpsum = "Lorem";

        return View("Index", loremIpsum);
    }


    // -------- Numbers Route ---------

    [HttpGet("/numbers")]
    public IActionResult Numbers()
    {
        List<int> intList = new List<int>() {1,2,3,4,5};

        return View(intList);
    }


    // -------- SingleUser Route ---------

    [HttpGet("/singleuser")]
    public IActionResult SingleUser()
    {
        User NewUser = new User()
        {
            UserName = "LeetCode",
            Password = "L33TC0D3"
        };

        return View(NewUser);
    }


    // -------- Users Route ---------

    [HttpGet("/users")]
    public IActionResult Users()
    {
        User NewUser = new User()
        {
            UserName = "LeetCode",
            Password = "L33TC0D3"
        };

        User NewerestUser = new User()
        {
            UserName = "LeetCoder",
            Password = "L33TC0D3R"
        };

        List<User> UserList = new List<User>() {NewUser, NewerestUser};

        return View(UserList);
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
