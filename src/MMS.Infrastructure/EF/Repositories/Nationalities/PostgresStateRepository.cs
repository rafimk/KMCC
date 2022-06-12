using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.Repositories.Nationalities;
using MMS.Domain.ValueObjects;
using MMS.Infrastructure.EF.Contexts;

namespace MMS.Infrastructure.EF.Repositories.Nationalities;

internal sealed class PostgresStateRepository : IStateRepository
{
    private readonly MMSDbContext _dbContext;

    public PostgresStateRepository(MMSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public  Task<State> GetByIdAsync(GenericId id)
        => _dbContext.States.SingleOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<State>> GetAsync()
        => await _dbContext.States.Where(x => !x.IsDeleted).ToListAsync();

    public async Task AddAsync(State states)
    {
        await _dbContext.States.AddAsync(states);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(State states)
    {
        _dbContext.States.Update(states);
        await _dbContext.SaveChangesAsync();
    }
}