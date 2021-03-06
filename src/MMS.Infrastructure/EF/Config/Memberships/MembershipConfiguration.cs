using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMS.Domain.Entities.Memberships;
using MMS.Domain.ValueObjects;

namespace MMS.Infrastructure.EF.Config.Memberships;

internal sealed class UserConfiguration : IEntityTypeConfiguration<Membership>
{
    public void Configure(EntityTypeBuilder<Membership> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasConversion(x => x.Value, x => new GenericId(x));
        builder.Property(x => x.MembershipId)
            .HasConversion(x => x.Value, x => new MembershipId(x))
            .IsRequired()
            .HasMaxLength(15);
        builder.Property(x => x.FullName)
            .HasConversion(x => x.Value, x => new FullName(x))
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x => x.EmiratesIdNumber)
            .HasConversion(x => x.Value, x => new EmiratesIdNumber(x))
            .IsRequired()
            .HasMaxLength(25);
        builder.Property(x => x.EmiratesIdExpiry)
            .HasConversion(x => x.Value, x => new Date(x))
            .IsRequired();
        builder.Property(x => x.DateOfBirth)
            .HasConversion(x => x.Value, x => new Date(x))
            .IsRequired();
        builder.Property(x => x.MobileNumber)
            .HasConversion(x => x.Value, x => new MobileNumber(x))
            .IsRequired()
            .HasMaxLength(20);
        builder.Property(x => x.AlternativeContactNumber)
            .HasConversion(x => x.Value, x => new MobileNumber(x))
            .IsRequired()
            .HasMaxLength(20);
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.Email)
            .HasConversion(x => x.Value, x => new Email(x))
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x => x.PassportNumber)
            .HasConversion(x => x.Value, x => new PassportNumber(x))
            .HasMaxLength(25);
        builder.Property(x => x.PassportExpiry)
            .HasConversion(x => x.Value, x => new Date(x))
            .IsRequired();
        builder.Property(x => x.ProfessionId)
            .HasConversion(x => x.Value, x => new GenericId(x))
            .IsRequired();
        builder.Property(x => x.QualificationId)
            .HasConversion(x => x.Value, x => new GenericId(x))
            .IsRequired();
        builder.Property(x => x.AreaId)
            .HasConversion(x => x.Value, x => new GenericId(x))
            .IsRequired();
        builder.Property(x => x.MandalamId)
            .HasConversion(x => x.Value, x => new GenericId(x))
            .IsRequired();
        builder.Property(x => x.CreatedBy)
            .HasConversion(x => x.Value, x => new GenericId(x))
            .IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
    }
}