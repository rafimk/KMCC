using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IMandalamRepository
{
    Task<Mandalam> GetAsync(GenericId id);
    Task<IEnumerable<Mandalam>> GetByDistrictAsync(GenericId districtId);
    Task<IEnumerable<Mandalam>> GetAllAsync();
    Task AddAsync(Mandalam mandalam);
    Task UpdateAsync(Mandalam mandalam);
    Task DeleteAsync(GenericId id);
}
