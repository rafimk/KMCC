using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.Repositories.Nationalities;
using MMS.Domain.ValueObjects;
using MMS.Infrastructure.EF.Contexts;

namespace MMS.Infrastructure.EF.Repositories.Nationalities;

internal sealed class PostgresPanchayatRepository : IPanchayatRepository
{
    private readonly MMSDbContext _dbContext;

    public PostgresPanchayatRepository(MMSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public  Task<Panchayat> GetByIdAsync(GenericId id)
        => _dbContext.Panchayats.Include(x => x.Mandalam).SingleOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<Panchayat>> GetAsync()
        => await _dbContext.Panchayats.Where(x => !x.IsDeleted).ToListAsync();
    
    public async Task<IEnumerable<Panchayat>> GetByMandalamIdAllAsync(GenericId mandalamId)
        => await _dbContext.Panchayats.Where(x => x.MandalamId == mandalamId && !x.IsDeleted).ToListAsync();

    public async Task AddAsync(Panchayat panchayat)
    {
        await _dbContext.Panchayats.AddAsync(panchayat);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Panchayat panchayat)
    {
        _dbContext.Panchayats.Update(panchayat);
        await _dbContext.SaveChangesAsync();
    }
}