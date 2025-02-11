using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace dt191_moment3.Models;

public class Author
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public List<Book> Books { get; set; } = new List<Book>();
}