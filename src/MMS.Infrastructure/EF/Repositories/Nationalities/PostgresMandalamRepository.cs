using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.Repositories.Nationalities;
using MMS.Domain.ValueObjects;
using MMS.Infrastructure.EF.Contexts;

namespace MMS.Infrastructure.EF.Repositories.Nationalities;

internal sealed class PostgresMandalamRepository : IMandalamRepository
{
    private readonly MMSDbContext _dbContext;

    public PostgresMandalamRepository(MMSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public  Task<Mandalam> GetByIdAsync(GenericId id)
        => _dbContext.Mandalams.Include(x => x.District).SingleOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<Mandalam>> GetAsync()
        => await _dbContext.Mandalams.Where(x => !x.IsDeleted).ToListAsync();
    
    public async Task<IEnumerable<Mandalam>> GetByDistrictIdAsync(GenericId districtId)
        => await _dbContext.Mandalams.Where(x => x.DistrictId == districtId && !x.IsDeleted).ToListAsync();

    public async Task AddAsync(Mandalam mandalam)
    {
        await _dbContext.Mandalams.AddAsync(mandalam);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Mandalam mandalam)
    {
        _dbContext.Mandalams.Update(mandalam);
        await _dbContext.SaveChangesAsync();
    }
}