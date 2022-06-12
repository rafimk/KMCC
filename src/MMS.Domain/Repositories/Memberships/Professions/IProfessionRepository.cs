using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities.Memberships.Professions;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Memberships.Professions;

public interface IProfessionRepository
{
    Task<Profession> GetByIdAsync(GenericId id);
    Task<IEnumerable<Profession>> GetAsync();
    Task AddAsync(Profession profession);
    Task UpdateAsync(Profession profession);
    Task DeleteAsync(GenericId id);
}
