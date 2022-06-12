using MMS.Domain.Consts;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.ValueObjects;
using MMS.Shared.Abstractions.Domain;

namespace MMS.Domain.Events.Nationalities
{
    public record PanchayatCreated(GenericId Id, PanchayatName Name, GenericId MandalamId, Mandalam Mandalam, PanchayatType Type) : IDomainEvent;
}