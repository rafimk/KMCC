using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMS.Domain.Entities.Memberships;
using MMS.Domain.ValueObjects;

namespace MMS.Infrastructure.EF.Config.Memberships;

internal sealed class MembershipPeriodConfiguration : IEntityTypeConfiguration<MembershipPeriod>
{
    public void Configure(EntityTypeBuilder<MembershipPeriod> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasConversion(x => x.Value, x => new GenericId(x));
        builder.Property(x => x.Start)
            .HasConversion(x => x.Value, x => new Date(x))
            .IsRequired();
        builder.Property(x => x.End)
            .HasConversion(x => x.Value, x => new Date(x))
            .IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
    }
}