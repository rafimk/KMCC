using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.Repositories.Nationalities;
using MMS.Domain.ValueObjects;
using MMS.Infrastructure.EF.Contexts;

namespace MMS.Infrastructure.EF.Repositories.Nationalities;

internal sealed class PostgresDistrictRepository : IDistrictRepository
{
    private readonly MMSDbContext _dbContext;

    public PostgresDistrictRepository(MMSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public  Task<District> GetByIdAsync(GenericId id)
        => _dbContext.Districts.SingleOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<District>> GetAsync()
        => await _dbContext.Districts.Where(x => !x.IsDeleted).ToListAsync();

    public async Task AddAsync(District district)
    {
        await _dbContext.Districts.AddAsync(district);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(District district)
    {
        _dbContext.Districts.Update(district);
        await _dbContext.SaveChangesAsync();
    }
}