#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyModels.Models;

public class DojoModelsSurvey
{
  [Required(ErrorMessage ="Name is Required")]
  [MinLength(2, ErrorMessage ="Name must be at least 2 char")]
  [NoZNames]
  public string Name {get;set;}

  [Required(ErrorMessage = "Location is Required")]
  [MinLength(2)]
  public string Location {get;set;}
  
  [Required]
  [MinLength(2)]
  public string Language {get;set;}
  public string Message {get;set;}
  
}

// Custom Validations

public class NoZNamesAttribute : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
  {
    if(((string)value).ToLower()[0] == 'z')
    {
      return new ValidationResult("Name can't start with Z");
    }
    else
    {
      return ValidationResult.Success;
    }
  }
}
