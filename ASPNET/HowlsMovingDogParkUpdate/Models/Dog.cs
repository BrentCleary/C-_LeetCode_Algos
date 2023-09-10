#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace HowlsMovingDogParkUpdate.Models;

public class Dog
{
    [Key]
    public int DogId{ get; set; }
    [Required]
    public string Name { get; set; } 
    public string Breed { get; set; }
    public int Weight { get; set; }
    public int Age { get; set; }
    public string Notes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public int UserId { get; set; }
    public User? Owner { get; set; }

}
