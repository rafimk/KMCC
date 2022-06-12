using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities.Memberships;
using MMS.Domain.Repositories.Memberships;
using MMS.Domain.ValueObjects;
using MMS.Infrastructure.EF.Contexts;

namespace MMS.Infrastructure.EF.Repositories.Memberships;

internal sealed class PostgresMembershipRepository : IMembershipRepository
{
    private readonly MMSDbContext _dbContext;

    public PostgresMembershipRepository(MMSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public  Task<Membership> GetByIdAsync(GenericId id)
        => _dbContext.Memberships.Include(x => x.Area)
                .Include(x => x.Mandalam).SingleOrDefaultAsync(x => x.Id == id);

    public  Task<Membership> GetByMembershipIdAsync(MembershipId membershipId)
        => _dbContext.Memberships.Include(x => x.Area)
            .Include(x => x.Mandalam).SingleOrDefaultAsync(x => x.MembershipId == membershipId);
    
    public async Task<IEnumerable<Membership>> GetAsync()
        => await _dbContext.Memberships.Where(x => x.IsActive).ToListAsync();
    
    public async Task<IEnumerable<Membership>> GetActiveAsync()
        => await _dbContext.Memberships.Include(x => x.Area)
            .Include(x => x.Mandalam).Where(x => x.IsActive).ToListAsync();

    public async Task<IEnumerable<Membership>> GetByAreaIdAsync(GenericId areaId)
        => await _dbContext.Memberships.Include(x => x.Area)
            .Include(x => x.Mandalam)
            .Where(x => x.IsActive && x.AreaId == areaId).ToListAsync();
    
    public async Task<IEnumerable<Membership>> GetByMandalamIdAsync(GenericId mandalamId)
        => await _dbContext.Memberships.Include(x => x.Area)
            .Include(x => x.Mandalam)
            .Where(x => x.IsActive && x.MandalamId == mandalamId).ToListAsync();
    
    public async Task AddAsync(Membership membership)
    {
        await _dbContext.Memberships.AddAsync(membership);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Membership membership)
    {
        _dbContext.Memberships.Update(membership);
        await _dbContext.SaveChangesAsync();
    }

    public async Task ActivateAsync(GenericId id)
    {
        var membership = await GetByIdAsync(id);
        membership.Activate();
        _dbContext.Memberships.Update(membership);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task DeactivateAsync(GenericId id)
    {
        var membership = await GetByIdAsync(id);
        membership.Deactivate();
        _dbContext.Memberships.Update(membership);
        await _dbContext.SaveChangesAsync();
    }
}