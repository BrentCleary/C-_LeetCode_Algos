#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
namespace DateValidator.Models;

public class Date
{
  [Required(ErrorMessage = "Date is Required")]
  [IsCurrent]
  public DateTime CurrentDate {get;set;}
  [Required(ErrorMessage = "Please provide some text")]
  public string TestVar {get;set;}
}

public class IsCurrentAttribute : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (((DateTime)value) > DateTime.Now)
        {
            return new ValidationResult("Date cannot be in the future");
        } else {
            return ValidationResult.Success;
        }
    }
}