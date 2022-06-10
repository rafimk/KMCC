using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities;
using MMS.Domain.Entities.Users;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IUserRepository
{
    Task<User> GetAsync(GenericId id);
    Task<User> GetByEmailAsync(Email email);
    Task<User> GetByMobileAsync(MobileNumber mobileNumber);
    Task<IEnumerable<User>> GetAllAsync();
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(GenericId id);
}