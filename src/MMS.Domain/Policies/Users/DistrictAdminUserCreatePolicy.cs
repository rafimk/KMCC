using MMS.Domain.Abstractions;
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Policies;

internal sealed class DistrictAdminUserCreatePolicy : IUserCreatePolicy
{
   
    public bool CanBeApplied(UserRole currentUserRole)
        => currentUserRole == UserRole.DistrictAdmin;

    public UserRole PermittedUserRole(UserRole currentUserRole)
    {
        return UserRole.MandalamAgent;
    }
}