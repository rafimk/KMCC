using System;
using MMS.Application.DTO.Nationalities.States;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Nationalities.States;

public class GetById : IQuery<StateDto>
{
    public Guid Id { get; set; }
}
