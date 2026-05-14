using _6_2_dars.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _6_2_dars.Configurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {

        builder.ToTable("Cars");

        builder.HasKey(x => x.CarId);

        builder.Property(x => x.Brand)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Model)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Year)
            .IsRequired();

        builder.Property(x => x.Color)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(x => x.Price)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(x => x.EngineNumber)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.VinNumber)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.FuelType)
            .IsRequired();

        builder.Property(x => x.PersonId)
            .IsRequired();

        builder.HasMany(c => c.CarParkings)
            .WithOne(cp => cp.Car)
            .HasForeignKey(cp => cp.CarId);

        builder.HasIndex(x => x.PersonId);
    }
}
