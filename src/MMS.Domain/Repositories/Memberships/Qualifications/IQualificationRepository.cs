using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities.Memberships.Qualifications;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Memberships.Qualifications;

public interface IQualificationRepository
{
    Task<Qualification> GetByIdAsync(GenericId id);
    Task<IEnumerable<Qualification>> GetAsync();
    Task AddAsync(Qualification qualification);
    Task UpdateAsync(Qualification qualification);
    Task DeleteAsync(GenericId id);
}
