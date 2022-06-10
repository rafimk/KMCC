using System;
using MMS.Application.DTO;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Nationalities.States;

public class GetState : IQuery<StateDto>
{
    public Guid Id { get; set; }
}
