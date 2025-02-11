using dt191_moment3.Models;
using Microsoft.EntityFrameworkCore;

namespace dt191_moment3.Data;

public class BookDbContext : DbContext 
{
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
    {

    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
}

