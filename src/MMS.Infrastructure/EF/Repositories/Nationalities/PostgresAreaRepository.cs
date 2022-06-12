using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.Repositories.Nationalities;
using MMS.Domain.ValueObjects;
using MMS.Infrastructure.EF.Contexts;

namespace MMS.Infrastructure.EF.Repositories.Nationalities;

internal sealed class PostgresAreaRepository : IAreaRepository
{
    private readonly MMSDbContext _dbContext;

    public PostgresAreaRepository(MMSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public  Task<Area> GetByIdAsync(GenericId id)
        => _dbContext.Areas.Include(x => x.State).SingleOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<Area>> GetByStateIdAsync(GenericId stateId)
        => await _dbContext.Areas.Where(x => x.StateId == stateId && !x.IsDeleted).ToListAsync();
    
    public async Task<IEnumerable<Area>> GetAsync()
        => await _dbContext.Areas.Where(x => !x.IsDeleted).ToListAsync();

    public async Task AddAsync(Area area)
    {
        await _dbContext.Areas.AddAsync(area);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Area area)
    {
        _dbContext.Areas.Update(area);
        await _dbContext.SaveChangesAsync();
    }
}