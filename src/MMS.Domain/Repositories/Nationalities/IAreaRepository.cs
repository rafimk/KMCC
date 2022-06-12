using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IAreaRepository
{
    Task<Area> GetByIdAsync(GenericId id);
    Task<IEnumerable<Area>> GetByStateIdAsync(GenericId stateId);
    Task<IEnumerable<Area>> GetAsync();
    Task AddAsync(Area area);
    Task UpdateAsync(Area area);
}
