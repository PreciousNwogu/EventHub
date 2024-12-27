using System.ComponentModel.DataAnnotations;

namespace EventHub;

public class Event
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = "";
    [Required]
    public DateTime Date { get; set; } = DateTime.Now;
    [Required]
    [EmailAddress]
    public string Email { get; set; } = "";
}
