using _6_2_dars.Configurations;
using _6_2_dars.Entities;
using Microsoft.EntityFrameworkCore;

namespace _6_2_dars.Data;

public class AppDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Passport> Passports { get; set; }
    public DbSet<CarParking> CarParkings { get; set; }
    public DbSet<Parking> Parkings { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.ApplyConfiguration(new PersonConfiguration());

    //    modelBuilder.ApplyConfiguration(new CarConfiguration());

    //    base.OnModelCreating(modelBuilder);
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
