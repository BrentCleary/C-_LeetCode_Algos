#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
// Adding DataAnnotations.Schema below allows for [NotMapped]
using System.ComponentModel.DataAnnotations.Schema;
namespace HowlsMovingDogPark.Models;

public class User
{
  [Key]
  public int UserId {get;set;}

  [Required]
  public string FirstName {get;set;}

  [Required]
  public string LastName {get;set;}

  [Required]
  [EmailAddress]
  [UniqueEmail]
  public string Email {get;set;}

  [Required]
  [DataType(DataType.Password)]
  [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
  public string Password {get;set;}

  [NotMapped]
  [DataType(DataType.Password)]
  [Compare("Password")]
  public string PasswordConfirm {get;set;}

  public DateTime CreatedAt {get;set;} = DateTime.Now;
  public DateTime UpdatedAt {get;set;} = DateTime.Now;

  // List of Owned Dogs
  public List<Dog> AllDogs {get;set;} = new List<Dog>();
  // List of Reserved Boarding Dates
  public List<UserBoardingReservation> BoardingReservations {get;set;} = new List<UserBoardingReservation>();



}




// Below is a check in our database (_context) for any objects holding the entered email in their email field

public class UniqueEmailAttribute : ValidationAttribute
{
  protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
  {
    if(value == null)
    {
      return new ValidationResult("Email is required");
    }

    MyContext _context = (MyContext)validationContext.GetService(typeof(MyContext));

    if(_context.Users.Any(e => e.Email == value.ToString()))
    {
      return new ValidationResult("Email already in use");
    }
    else
    {
      return ValidationResult.Success;
    }
  }
}



/* 

Below is the platform example
This is placed here for reference if there are any errors

public class UniqueEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
    	// Though we have Required as a validation, sometimes we make it here anyways
    	// In which case we must first verify the value is not null before we proceed
        if(value == null)
        {
    	    // If it was, return the required error
            return new ValidationResult("Email is required!");
        }
    
    	// This will connect us to our database since we are not in our Controller
        MyContext _context = (MyContext)validationContext.GetService(typeof(MyContext));
        // Check to see if there are any records of this email in our database
      if(_context.Users.Any(e => e.Email == value.ToString()))
        {
    	    // If yes, throw an error
            return new ValidationResult("Email must be unique!");
        } else {
    	    // If no, proceed
            return ValidationResult.Success;
        }
    }
}




*/