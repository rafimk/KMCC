using MMS.Domain.ValueObjects;
using MMS.Shared.Abstractions.Domain;

namespace MMS.Domain.Events.Nationalities
{
    public record DistrictCreated(GenericId Id, DistrictName Name) : IDomainEvent;
}