using _6_2_dars.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _6_2_dars.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("People");

        builder.HasKey(p => p.PersonId);

        builder.Property(p => p.PersonId)
            .ValueGeneratedOnAdd();

        builder.Property(p => p.FirstName)
            .IsRequired(true)
            .HasMaxLength(50);

        builder.Property(p => p.LastName)
            .IsRequired(false)
            .HasMaxLength(50);

        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(p => p.Address)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.BirthDate)
            .IsRequired();

        builder.Property(p => p.IsMarried)
            .IsRequired();

        builder.HasMany(p => p.Cars)
            .WithOne(c => c.Person)
            .HasForeignKey(c => c.PersonId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(p => p.Passport)
            .WithOne(c => c.Person)
            .HasForeignKey<Passport>(c => c.PersonId)
            .OnDelete(DeleteBehavior.Cascade);

        // Index
        builder.HasIndex(p => p.Email)
            .IsUnique(true);

        builder.HasIndex(p => p.PhoneNumber)
            .IsUnique(true);
    }
}
