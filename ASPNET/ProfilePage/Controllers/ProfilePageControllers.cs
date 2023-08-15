using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace ProfilePage.Controllers;   
public class ProfilePageController : Controller   // Remember inheritance?    
{      
    [HttpGet("")] // We will go over this in more detail on the next page
    public ViewResult Index()        
    {            
      return View("Index");        
    }

    [HttpGet("projects")]
    public ViewResult Projects()
    {
      return View("Projects");
    }

  [HttpGet("contact")]
  public ViewResult Contact()
  {
    return View("Contact");
  }

}

