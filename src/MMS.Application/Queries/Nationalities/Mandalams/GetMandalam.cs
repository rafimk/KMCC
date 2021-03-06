using System;
using MMS.Application.DTO;
using MMS.Application.DTO.Nationalities.Mandalams;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Nationalities.Mandalams;

public class GetMandalam : IQuery<MandalamDto>
{
    public Guid Id { get; set; }
}
