using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IMandalamRepository
{
    Task<Mandalam> GetByIdAsync(GenericId id);
    Task<IEnumerable<Mandalam>> GetByDistrictIdAsync(GenericId districtId);
    Task<IEnumerable<Mandalam>> GetAsync();
    Task AddAsync(Mandalam mandalam);
    Task UpdateAsync(Mandalam mandalam);
}
