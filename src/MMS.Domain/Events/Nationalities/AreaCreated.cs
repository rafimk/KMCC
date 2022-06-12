using MMS.Domain.Entities.Nationalities;
using MMS.Domain.ValueObjects;
using MMS.Shared.Abstractions.Domain;

namespace MMS.Domain.Events.Nationalities
{
    public record AreaCreated(GenericId Id, AreaName Name, GenericId StateId, State State, string Prefix) : IDomainEvent;
}