using MMS.Domain.Abstractions;
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Policies;

internal sealed class StateAdminUserCreatePolicy : IUserCreatePolicy
{
   
    public bool CanBeApplied(UserRole currentUserRole)
        => currentUserRole == UserRole.StateAdmin;

    public UserRole PermittedUserRole(UserRole currentUserRole)
    {
        return UserRole.DistrictAdmin;
    }
}