using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities.Memberships;
using MMS.Domain.Entities.Memberships.Professions;
using MMS.Domain.Entities.Memberships.Qualifications;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.Entities.Users;

namespace MMS.Infrastructure.EF.Contexts;

internal sealed class MMSDbContext : DbContext
{
    public DbSet<Area> Areas { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Mandalam> Mandalams { get; set; }
    public DbSet<Panchayat> Panchayats { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Profession> Professions { get; set; }
    public DbSet<Qualification> Qualifications { get; set; }
    public DbSet<Membership> Memberships { get; set; }
    public DbSet<MembershipPeriod> MembershipPeriods { get; set; }

    public MMSDbContext(DbContextOptions<MMSDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("MMS");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}