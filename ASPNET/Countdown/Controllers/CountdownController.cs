// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace Countdown.Controllers;   
public class CountdownController : Controller   // Remember inheritance?    
{      
    [HttpGet("/")] // We will go over this in more detail on the next page    
    public IActionResult Index()        
    {            
      DateTime currentTime = DateTime.Now;
      ViewBag.CurrentTime = currentTime;
      
      DateTime endTime = new DateTime(2024, 05, 05, 11, 59, 0);
      ViewBag.EndTime = endTime;

      TimeSpan timeRemaining = (endTime - currentTime);
      
      string readableTR = string.Format("{0:D2} days, {1:D2} hours, {2:D2} minutes, {3:D2} seconds", timeRemaining.Days, timeRemaining.Hours, timeRemaining.Minutes, timeRemaining.Seconds);

      ViewBag.timeString = readableTR;
    	
      return View();        
    }    
}

