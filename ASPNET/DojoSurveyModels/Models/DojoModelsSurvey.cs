#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyModels.Models;

public class DojoModelsSurvey
{
  [Required(ErrorMessage ="Name is Required")]
  [MinLength(2, ErrorMessage ="Name must be at least 2 char")]
  public string Name {get;set;}
  [Required(ErrorMessage = "Location is Required")]
  [MinLength(2)]
  public string Location {get;set;}
  [Required]
  [MinLength(2)]
  public string Language {get;set;}
  public string Message {get;set;}
  
}

public class CustomValidations : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
  {
    if (LogicToBreakValidation)
    {
      return new ValidationResult("Custom error message");
    }
    else
    {
      return ValidationResult.Success;
    }
  }
}
