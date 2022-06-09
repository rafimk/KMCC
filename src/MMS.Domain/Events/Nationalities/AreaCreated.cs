using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;
using MMS.Shared.Abstractions.Domain;

namespace MMS.Domain.Events.Users
{
    public record AreaCreated(GenericId Id, AreaName Name, GenericId StateId, State State, string Prefix) : IDomainEvent;
}