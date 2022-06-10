using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IDistrictRepository
{
    Task<District> GetAsync(GenericId id);
    Task<IEnumerable<District>> GetAllAsync();
    Task AddAsync(District district);
    Task UpdateAsync(District district);
    Task DeleteAsync(GenericId id);
}
