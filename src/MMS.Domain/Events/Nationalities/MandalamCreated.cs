using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;
using MMS.Shared.Abstractions.Domain;

namespace MMS.Domain.Events.Users
{
    public record MandalamCreated(GenericId Id, MandalamName Name, GenericId DistrictId, District District) : IDomainEvent;
}