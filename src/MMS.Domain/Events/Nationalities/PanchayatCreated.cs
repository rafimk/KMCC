using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;
using MMS.Shared.Abstractions.Domain;

namespace MMS.Domain.Events.Users
{
    public record PanchayatCreated(GenericId Id, PanchayatName Name, GenericId MandalamId, Mandalam Mandalam, PanchayatType Type) : IDomainEvent;
}