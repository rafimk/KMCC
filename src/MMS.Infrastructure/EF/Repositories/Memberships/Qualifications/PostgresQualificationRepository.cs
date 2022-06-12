using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities.Memberships.Qualifications;
using MMS.Domain.Repositories.Memberships.Qualifications;
using MMS.Domain.ValueObjects;
using MMS.Infrastructure.EF.Contexts;

namespace MMS.Infrastructure.EF.Repositories.Memberships.Qualifications;

internal sealed class PostgresQualificationRepository : IQualificationRepository
{
    private readonly MMSDbContext _dbContext;

    public PostgresQualificationRepository(MMSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public  Task<Qualification> GetByIdAsync(GenericId id)
        => _dbContext.Qualifications.SingleOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<Qualification>> GetAsync()
        => await _dbContext.Qualifications.Where(x => !x.IsDeleted).ToListAsync();

    public async Task AddAsync(Qualification qualification)
    {
        await _dbContext.Qualifications.AddAsync(qualification);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Qualification qualification)
    {
        _dbContext.Qualifications.Update(qualification);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(GenericId id)
    {
        var qualification = await GetByIdAsync(id);
        qualification.Delete();
        _dbContext.Qualifications.Update(qualification);
        await _dbContext.SaveChangesAsync();
    }
}