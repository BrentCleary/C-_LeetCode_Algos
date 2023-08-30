#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace HowlsMovingDogPark.Models;

public class Reservation
{
  [Key]
  public int ReservationId {get;set;}
  public DateTime Date {get;set;}
  public string Notes {get;set;}

}