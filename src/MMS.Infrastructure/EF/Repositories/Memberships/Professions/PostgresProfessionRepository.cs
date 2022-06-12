using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities.Memberships.Professions;
using MMS.Domain.Repositories.Memberships.Professions;
using MMS.Domain.ValueObjects;
using MMS.Infrastructure.EF.Contexts;

namespace MMS.Infrastructure.EF.Repositories.Memberships.Professions;

internal sealed class PostgresProfessionRepository : IProfessionRepository
{
    private readonly MMSDbContext _dbContext;

    public PostgresProfessionRepository(MMSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public  Task<Profession> GetByIdAsync(GenericId id)
        => _dbContext.Professions.SingleOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<Profession>> GetAsync()
        => await _dbContext.Professions.Where(x => !x.IsDeleted).ToListAsync();

    public async Task AddAsync(Profession profession)
    {
        await _dbContext.Professions.AddAsync(profession);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Profession profession)
    {
        _dbContext.Professions.Update(profession);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(GenericId id)
    {
        var profession = await GetByIdAsync(id);
        profession.Delete();
        _dbContext.Professions.Update(profession);
        await _dbContext.SaveChangesAsync();
    }
}