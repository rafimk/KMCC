using System.Threading.Tasks;
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IMembershipPeriodRepository
{
    Task<MembershipPeriod> GetAsync(GenericId id);
    Task<IEnumerable<MembershipPeriod>> GetAllAsync();
    Task<MembershipPeriod> GetActivePeriodAsync();
    Task AddAsync(MembershipPeriod membershipPeriod);
    Task UpdateAsync(MembershipPeriod membershipPeriod);
    Task DeleteAsync(GenericId id);
}
