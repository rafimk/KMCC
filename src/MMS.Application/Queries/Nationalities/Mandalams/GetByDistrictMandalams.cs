using System;
using MMS.Application.DTO;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Nationalities.Mandalams;

public class GetByDistrictMandalams : IQuery<IEnumerable<MandalamDto>>
{
    public Guid DistrictId { get; set; }
}