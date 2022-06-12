using System;
using System.Collections.Generic;
using MMS.Application.DTO;
using MMS.Application.DTO.Nationalities.Mandalams;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Nationalities.Mandalams;

public class GetByDistrictMandalams : IQuery<IEnumerable<MandalamDto>>
{
    public Guid DistrictId { get; set; }
}