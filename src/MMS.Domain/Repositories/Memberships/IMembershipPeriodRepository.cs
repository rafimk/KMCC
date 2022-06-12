using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities.Memberships;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Memberships;

public interface IMembershipPeriodRepository
{
    Task<MembershipPeriod> GetByIdAsync(GenericId id);
    Task<IEnumerable<MembershipPeriod>> GetAsync();
    Task<MembershipPeriod> GetActivePeriodAsync();
    Task AddAsync(MembershipPeriod membershipPeriod);
    Task UpdateAsync(MembershipPeriod membershipPeriod);
}
