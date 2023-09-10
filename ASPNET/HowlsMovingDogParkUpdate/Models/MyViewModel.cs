#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace HowlsMovingDogParkUpdate.Models;

public class MyViewModel
{
  public User CurrentUser {get;set;}
  public List<Dog> CurrentUserDogs {get;set;}
}