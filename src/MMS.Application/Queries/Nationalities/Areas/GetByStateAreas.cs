using System;
using System.Collections.Generic;
using MMS.Application.DTO;
using MMS.Application.DTO.Nationalities.Areas;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Nationalities.Areas;

public class GetByStateAreas : IQuery<IEnumerable<AreaDto>>
{
    public Guid stateId { get; set; }
}