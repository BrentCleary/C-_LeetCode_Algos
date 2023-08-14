using Microsoft.AspNetCore.Mvc;
namespace FirstWeb.Controllers;

public class HelloController : Controller
{
  [HttpGet]
  [Route("")]
  public string Index()
  {
    return "Hello World from HelloController!";
  }

  [HttpGet("greet/{name}")]
  // [Route("about")]
  public string Greet(string name)
  {
    return $"Hello {name}.";
  }
}