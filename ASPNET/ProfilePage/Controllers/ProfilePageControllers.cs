using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace ProfilePage.Controllers;   
public class HelloController : Controller   // Remember inheritance?    
{      
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public ViewResult Index()        
    {            
    	return View("Index");        
    }

    [HttpGet("testing")]
    public ViewResult Testing()
    {
      return View("TestTest");
    }

  [HttpGet("numbers/{nums}")]
  public string GetNumbers(string nums)
  {
    return $"These are the numbers: {nums}";
  }

  [HttpGet("lastpart/{finalstring}")]
  public string FinalString(string finalstring)
  {
    return $"Last page for strings. Also, {finalstring}";
  }

}

