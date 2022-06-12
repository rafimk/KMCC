using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IDistrictRepository
{
    Task<District> GetByIdAsync(GenericId id);
    Task<IEnumerable<District>> GetAsync();
    Task AddAsync(District district);
    Task UpdateAsync(District district);
}
