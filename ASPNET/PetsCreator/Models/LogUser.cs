#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace PetsCreator.Models;

public class LogUser
{
  [Required(ErrorMessage = "Email is Required")]
  [EmailAddress]
  [Display(Name = "Email")]
  public string LEmail {get;set;}

  [Required(ErrorMessage = "Password is Required")]
  [DataType(DataType.Password)]
  [Display(nameof = "Password")]
  public string LPassword {get;set;}

}