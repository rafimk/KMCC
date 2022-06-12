using System;
using MMS.Application.DTO;
using MMS.Application.DTO.Nationalities.Areas;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Nationalities.Areas;

public class GetArea : IQuery<AreaDto>
{
    public Guid Id { get; set; }
}
