#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace HowlsMovingDogPark.Models;

public class Boarding
{
  [Key]
  public int BoardingId {get;set;}
  public DateTime Date {get;set;}
  public string Notes {get;set;}
  public DateTime CreatedAt {get;set;}
  public DateTime UpdatedAt {get;set;}

  // List of 
  public List<UserBoardingReservation> UserReservations {get;set;} = new List<UserBoardingReservation>();

}