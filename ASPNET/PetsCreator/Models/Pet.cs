#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace PetsCreator.Models;
public class Pet
{
    [Key]
    public int? PetId { get; set; }
    
    [Required(ErrorMessage = "Field Cannot Be Empty")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Field Cannot Be Empty")]
    public string Species { get; set; }

    [Required(ErrorMessage = "Field Cannot Be Empty")]
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // One Owner per Pet
    public int UserId { get;set; }
    // Navigation Property
    public User? Owner { get;set; }
}
