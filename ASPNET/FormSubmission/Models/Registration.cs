#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models;

public class Registration
{
  [Required(ErrorMessage = "Name is Required")]
  [MinLength(2, ErrorMessage = "Name must be at least 2 characters.")]
  public string Name {get;set;}

  [Required(ErrorMessage = "Email is Required")]
  [EmailAddress(ErrorMessage = "Invalid Email Address")]
  // This was found at https://mailtrap.io/blog/validate-email-address-c/
  [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$", ErrorMessage = "Invalid Email Address.")]
  public string Email {get;set;}

  [Required(ErrorMessage = "Date of Birth is Required")]
  [PastBirthday]
  public DateTime DateOfBirth {get;set;}

  [Required(ErrorMessage = "Password is Required")]
  [MinLength(8, ErrorMessage = "Password must be at least 8 char")]
  public string Password {get;set;}

  [Required(ErrorMessage = "Favorite Odd Number is Required")]
  [OddNumber]
  public int FavoriteOddNum {get;set;}
}

// Birthday in the Past Validation

public class PastBirthdayAttribute : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (((DateTime)value) > DateTime.Now)
        {
            return new ValidationResult("Date of Birth must be in the past.");
        } else {
            return ValidationResult.Success;
        }
    }
}

// Odd Number Check Validation

public class OddNumberAttribute : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (((int)value) % 2 == 0)
        {
            return new ValidationResult("Number must be Odd");
        } else {
            return ValidationResult.Success;
        }
    }
}