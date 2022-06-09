using MMS.Domain.Consts;

namespace MMS.Domain.Policies;

public interface IUserCreatePolicy
{
    bool CanBeApplied(UserRole currentUserRole);
    UserRole PermittedUserRole(UserRole currentUserRole);
}