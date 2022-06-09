using MMS.Domain.Abstractions;
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Policies;

internal sealed class CentralCommitteeUserCreatePolicy : IUserCreatePolicy
{
   
    public bool CanBeApplied(UserRole currentUserRole)
        => currentUserRole == UserRole.CentralCommitteeAdmin;

    public UserRole PermittedUserRole(UserRole currentUserRole)
    {
        return UserRole.StateAdmin;
    }
}