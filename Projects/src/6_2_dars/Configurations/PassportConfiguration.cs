using _6_2_dars.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _6_2_dars.Configurations;

public class PassportConfiguration : IEntityTypeConfiguration<Passport>
{
    public void Configure(EntityTypeBuilder<Passport> builder)
    {
        builder.ToTable("Passports");

        builder.HasKey(x => x.PassportId);

        builder.Property(x => x.SeriaNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Color)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(x => x.PersonId)
            .IsUnique(true);
    }
}
