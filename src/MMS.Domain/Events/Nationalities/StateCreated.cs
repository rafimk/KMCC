using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;
using MMS.Shared.Abstractions.Domain;

namespace MMS.Domain.Events.Users
{
    public record StateCreated(GenericId Id, StateName Name) : IDomainEvent;
}