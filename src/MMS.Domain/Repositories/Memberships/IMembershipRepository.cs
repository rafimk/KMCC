using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities.Memberships;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Memberships;

public interface IMembershipRepository
{
    Task<Membership> GetByIdAsync(GenericId id);
    Task<Membership> GetByMembershipIdAsync(MembershipId membershipId);
    Task<IEnumerable<Membership>> GetAsync();
    Task<IEnumerable<Membership>> GetActiveAsync();
    Task<IEnumerable<Membership>> GetByAreaIdAsync(GenericId areaId);
    Task<IEnumerable<Membership>> GetByMandalamIdAsync(GenericId mandalamId);
    Task AddAsync(Membership membership);
    Task UpdateAsync(Membership membership);
    Task ActivateAsync(GenericId id);
    Task DeactivateAsync(GenericId id);
}