using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.ValueObjects;

namespace MMS.Infrastructure.EF.Config.Nationalities;

internal sealed class MandalamConfiguration : IEntityTypeConfiguration<Mandalam>
{
    public void Configure(EntityTypeBuilder<Mandalam> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasConversion(x => x.Value, x => new GenericId(x));
        builder.Property(x => x.Name)
            .HasConversion(x => x.Value, x => new MandalamName(x))
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x => x.DistrictId)
            .HasConversion(x => x.Value, x => new GenericId(x))
            .IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
    }
}