using MMS.Domain.Entities.Nationalities;
using MMS.Domain.ValueObjects;
using MMS.Shared.Abstractions.Domain;

namespace MMS.Domain.Events.Nationalities
{
    public record MandalamCreated(GenericId Id, MandalamName Name, GenericId DistrictId, District District) : IDomainEvent;
}