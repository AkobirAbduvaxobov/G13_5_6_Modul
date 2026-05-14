using _6_2_dars.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _6_2_dars.Configurations;

public class ParkingConfiguration : IEntityTypeConfiguration<Parking>
{
    public void Configure(EntityTypeBuilder<Parking> builder)
    {
        builder.HasKey(p => p.ParkingId);

        builder.HasMany(p => p.CarParkings)
        .WithOne(cp => cp.Parking)
        .HasForeignKey(cp => cp.ParkingId);
    }
}
