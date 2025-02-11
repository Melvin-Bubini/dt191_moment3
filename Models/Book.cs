using System.ComponentModel.DataAnnotations;

namespace dt191_moment3.Models;

public class Book
{
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Genre { get; set; }
    [Required]
    public int PublicationYear { get; set; }

    public int AuthorId { get; set; }
    public Author? Author { get; set; }

}