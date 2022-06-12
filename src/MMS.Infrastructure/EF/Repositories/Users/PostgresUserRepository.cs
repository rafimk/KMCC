using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities.Users;
using MMS.Domain.Repositories.Users;
using MMS.Domain.ValueObjects;
using MMS.Infrastructure.EF.Contexts;

namespace MMS.Infrastructure.EF.Repositories.Users;

internal sealed class PostgresUserRepository : IUserRepository
{
    private readonly MMSDbContext _dbContext;

    public PostgresUserRepository(MMSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public  Task<User> GetByIdAsync(GenericId id)
        => _dbContext.Users.SingleOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<User>> GetAsync()
        => await _dbContext.Users.Where(x => x.IsActive).ToListAsync();
    
    public  Task<User> GetByEmailAsync(Email email)
        => _dbContext.Users.SingleOrDefaultAsync(x => x.Email == email);
    
    public  Task<User> GetByMobileAsync(MobileNumber mobileNumber)
        => _dbContext.Users.SingleOrDefaultAsync(x => x.MobileNumber == mobileNumber);

    public async Task AddAsync(User users)
    {
        await _dbContext.Users.AddAsync(users);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(User users)
    {
        _dbContext.Users.Update(users);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Activate(GenericId id)
    {
        var users = await GetByIdAsync(id);
        users.Activate();
        _dbContext.Users.Update(users);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task Deactivate(GenericId id)
    {
        var users = await GetByIdAsync(id);
        users.Deactivate();
        _dbContext.Users.Update(users);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task ChangePassword(GenericId id, string newPasswordHash)
    {
        var users = await GetByIdAsync(id);
        users.ChangePassword(newPasswordHash);
        _dbContext.Users.Update(users);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task Verify(GenericId id, DateTime verifiedAt)
    {
        var users = await GetByIdAsync(id);
        users.Verify(verifiedAt);
        _dbContext.Users.Update(users);
        await _dbContext.SaveChangesAsync();
    }
}