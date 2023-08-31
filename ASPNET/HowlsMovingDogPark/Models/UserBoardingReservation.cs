#pragma warning disable CS8618
using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations;
namespace HowlsMovingDogPark.Models;

// Joining Table
public class UserBoardingReservation
{
  [Key]
  public int UserBoardingReservationId {get;set;}

  public DateTime CreatedAt {get;set;} = DateTime.Now;
  public DateTime UpdatedAt {get;set;} = DateTime.Now;

  public int UserId {get;set;}
  public int BoardingId {get;set;}
  
  public User? ReservedUser {get;set;}
  public Boarding? ReservedBoarding {get;set;}
}