using MMS.Domain.Consts;
using MMS.Domain.ValueObjects;
using MMS.Shared.Abstractions.Domain;

namespace MMS.Domain.Events.Users
{
    public record UserCreated(GenericId Id, FullName FullName, Email Email, MobileNumber MobileNumber,
        MobileNumber AlternativeContactNumber, UserRole Role) : IDomainEvent;
}