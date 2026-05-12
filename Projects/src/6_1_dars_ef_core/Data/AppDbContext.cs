using _6_1_dars_ef_core.Entities;
using Microsoft.EntityFrameworkCore;

namespace _6_1_dars_ef_core.Data;

public class AppDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Student> Students { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    
}
