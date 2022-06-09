using System.Threading.Tasks;
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IMembershipRepository
{
    Task<Membership> GetAsync(GenericId id);
    Task<Membership> GetByMembershipIdAsync(MembershipId membershipId);
    Task<IEnumerable<Membership>> GetAllAsync();
    Task<IEnumerable<Membership>> GetActiveAsync();
    Task<IEnumerable<Membership>> GetByStateAsync(GenericId stateId);
    Task<IEnumerable<Membership>> GetByMandalamAsync(GenericId mandalamId);
    Task AddAsync(Membership membership);
    Task UpdateAsync(Membership membership);
    Task DeleteAsync(GenericId id);
}