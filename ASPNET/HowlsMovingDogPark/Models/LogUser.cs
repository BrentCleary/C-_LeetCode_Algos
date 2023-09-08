#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace HowlsMovingDogPark.Models;

public class LogUser
{
  [Required(ErrorMessage = "Email is Required")]
  [EmailAddress]
  [Display(Name = "Email")]
  public string LEmail {get;set;}
jn
  [Required(ErrorMessage = "Password is Required")]
  [DataType(DataType.Password)]
  [Display(Name = "Password")]
  public string LPassword {get;set;}

}