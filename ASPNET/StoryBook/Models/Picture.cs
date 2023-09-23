#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace StoryBook.Models;
public class Picture
{
    [Key]
    public int PictureId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public byte[] ImageData { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
